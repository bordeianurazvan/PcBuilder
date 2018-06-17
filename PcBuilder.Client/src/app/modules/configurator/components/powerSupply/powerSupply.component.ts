import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { PowerSupply } from '../../shared/models/powerSupply';
import { VideoCard } from '../../shared/models/videoCard';
import { Ram } from '../../shared/models/ram';
import { Motherboard } from '../../shared/models/motherboard';
import { Cooler } from '../../shared/models/cooler';
import { Cpu } from '../../shared/models/cpu';
import { Case } from '../../shared/models/case';
import { Computer } from '../../shared/models/Computer';

@Component({
  selector: 'app-powersupply',
  templateUrl: './powerSupply.component.html',
  styleUrls: ['./powerSupply.component.css']
})
export class PowerSupplyComponent implements OnInit {
  storageSelected: Storage;
  videocardSelected: VideoCard;
  ramSelected: Ram;
  motherboardSelected: Motherboard;
  coolerSelected: Cooler;
  cpuSelected: Cpu;
  caseSelected: Case;
  powersupplies: PowerSupply[];
  isDisabled = true;
  selectedPowersupplyId: string;
  currentTotalPrice: number;

  powersupplySelected($event) {
    if (this.selectedPowersupplyId === $event) {
      this.selectedPowersupplyId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getPowersupplyById($event).price;
    } else {
      for (let i = 0; i < this.powersupplies.length; i++) {
        if ($event !== this.powersupplies[i].id) {
          if (this.powersupplies[i].isSelected) {
            this.currentTotalPrice =
              this.currentTotalPrice - this.getPowersupplyById(this.powersupplies[i].id).price;
          }
          this.powersupplies[i].isSelected = false;
        }
      }
      this.selectedPowersupplyId = $event;
      this.isDisabled = false;
      this.currentTotalPrice =
        this.caseSelected.price +
        this.cpuSelected.price +
        this.motherboardSelected.price +
        this.ramSelected.price +
        this.videocardSelected.price +
        this.storageSelected.price +
        this.getPowersupplyById(this.selectedPowersupplyId).price;
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
      this.configService.computer.storageId = this.storageSelected.id;
      this.configService.computer.powersupplyId = this.selectedPowersupplyId;
      this.configService.price = this.currentTotalPrice;
    }
  }

  goToStorage() {
    this.configService.progress = this.configService.progress - 15;
    this.router.navigate(['/configurator/storage']);
  }

  goToResult() {
    this.configService.computer.powersupplyId = this.selectedPowersupplyId;
    this.configService.price = this.currentTotalPrice;
    this.router.navigate(['']);
  }

  getPowersupplyById(id: string) {
    if (id !== undefined) {
      return this.powersupplies.find(c => c.id === id);
    }
  }
  constructor(private router: Router, private configService: ConfigComputerService) {}

  ngOnInit() {
    this.configService.powersupplies
      .getAll(JSON.stringify(this.configService.computer))
      .subscribe(response => {
        this.powersupplies = response;
        this.currentTotalPrice = this.configService.price;
        if (this.configService.computer.powersupplyId !== '') {
          this.powersupplies.find(
            c => c.id === this.getPowersupplyById(this.configService.computer.powersupplyId).id
          ).isSelected = true;
          this.isDisabled = false;
        }
        this.selectedPowersupplyId = this.configService.computer.powersupplyId;
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

    this.configService.videocards
      .getById(this.configService.computer.videocardId)
      .subscribe(response => {
        this.videocardSelected = response;
      });

    this.configService.storages
      .getById(this.configService.computer.storageId)
      .subscribe(response => {
        this.storageSelected = response;
      });
  }
}
