import { Component, OnInit } from '@angular/core';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Router } from '@angular/router';
import { VideoCard } from '../../shared/models/videoCard';
import { Ram } from '../../shared/models/ram';
import { Motherboard } from '../../shared/models/motherboard';
import { Cooler } from '../../shared/models/cooler';
import { Cpu } from '../../shared/models/cpu';
import { Case } from '../../shared/models/case';
import { Computer } from '../../shared/models/Computer';

@Component({
  selector: 'app-storage',
  templateUrl: './storage.component.html',
  styleUrls: ['./storage.component.css']
})
export class StorageComponent implements OnInit {
  videocardSelected: VideoCard;
  ramSelected: Ram;
  motherboardSelected: Motherboard;
  coolerSelected: Cooler;
  cpuSelected: Cpu;
  caseSelected: Case;
  storages: any[];
  isDisabled = true;
  selectedStorageId: string;
  currentTotalPrice: number;

  storageSelected($event) {
    if (this.selectedStorageId === $event) {
      this.selectedStorageId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getStorageById($event).price;
    } else {
      for (let i = 0; i < this.storages.length; i++) {
        if ($event !== this.storages[i].id) {
          if (this.storages[i].isSelected) {
            this.currentTotalPrice = this.currentTotalPrice - this.getStorageById(this.storages[i].id).price;
          }
          this.storages[i].isSelected = false;
        }
      }
      this.selectedStorageId = $event;
      this.isDisabled = false;
      this.currentTotalPrice =
        this.caseSelected.price +
        this.cpuSelected.price +
        this.motherboardSelected.price +
        this.ramSelected.price +
        this.videocardSelected.price +
        this.getStorageById(this.selectedStorageId).price;
      if (this.coolerSelected != null) {
        this.currentTotalPrice = this.currentTotalPrice + this.coolerSelected.price;
      }

      this.configService.computer = new Computer();
      this.configService.computer.caseId = this.caseSelected.id;
      this.configService.computer.cpuId = this.cpuSelected.id;

      if (this.coolerSelected != null) {
        this.configService.computer.coolerId = this.coolerSelected.id;
      }

      this.configService.computer.motherboardId = this.motherboardSelected.id;
      this.configService.computer.ramId = this.ramSelected.id;
      this.configService.computer.videocardId = this.videocardSelected.id;
      this.configService.computer.storageId = this.selectedStorageId;
      this.configService.price = this.currentTotalPrice;
    }
  }

  goToVideocard() {
    this.configService.progress = this.configService.progress - 15;
    this.router.navigate(['/configurator/videocard']);
  }

  goToPowersupply() {
    this.configService.computer.storageId = this.selectedStorageId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 15;
    this.router.navigate(['configurator/powersupply']);
  }

  getStorageById(id: string) {
    if (id !== undefined) {
      return this.storages.find(c => c.id === id);
    }
  }


  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.configService.storages.getAll(JSON.stringify(this.configService.computer)).subscribe(response => {
      this.storages = response;
      this.currentTotalPrice = this.configService.price;
      if (this.configService.computer.storageId !== '') {
        this.storages.find(
          c => c.id === this.getStorageById(this.configService.computer.storageId).id
        ).isSelected = true;
        this.isDisabled = false;
      }
      this.selectedStorageId = this.configService.computer.storageId;

    });
    console.log(this.configService.computer);

    this.configService.cases.getById(this.configService.computer.caseId).subscribe(response => {
      this.caseSelected = response;
    });

    this.configService.cpus.getById(this.configService.computer.cpuId).subscribe(response => {
      this.cpuSelected = response;
    });

    if (this.configService.computer.coolerId !== '') {
      this.configService.coolers
        .getById(this.configService.computer.coolerId)
        .subscribe(response => {
          this.coolerSelected = response;
        });
    }

    this.configService.motherboards
      .getById(this.configService.computer.motherboardId)
      .subscribe(response => {
        this.motherboardSelected = response;
      });

    this.configService.rams.getById(this.configService.computer.ramId).subscribe(response => {
      this.ramSelected = response;
    });

    this.configService.videocards.getById(this.configService.computer.videocardId).subscribe(response => {
      this.videocardSelected = response;
    });
  }

}
