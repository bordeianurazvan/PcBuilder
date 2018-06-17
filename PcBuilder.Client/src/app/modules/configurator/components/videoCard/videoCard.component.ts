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
  selector: 'app-videocard',
  templateUrl: './videoCard.component.html',
  styleUrls: ['./videoCard.component.css']
})
export class VideoCardComponent implements OnInit {
  ramSelected: Ram;
  motherboardSelected: Motherboard;
  coolerSelected: Cooler;
  cpuSelected: Cpu;
  caseSelected: Case;
  videocards: VideoCard[];
  isDisabled = true;
  selectedvideocardId: string;
  currentTotalPrice: number;

  videocardSelected($event) {
    if (this.selectedvideocardId === $event) {
      this.selectedvideocardId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getVideocardById($event).price;
    } else {
      for (let i = 0; i < this.videocards.length; i++) {
        if ($event !== this.videocards[i].id) {
          if (this.videocards[i].isSelected) {
            this.currentTotalPrice =
              this.currentTotalPrice - this.getVideocardById(this.videocards[i].id).price;
          }
          this.videocards[i].isSelected = false;
        }
      }
      this.selectedvideocardId = $event;
      this.isDisabled = false;
      this.currentTotalPrice =
        this.caseSelected.price +
        this.cpuSelected.price +
        this.motherboardSelected.price +
        this.ramSelected.price +
        this.getVideocardById(this.selectedvideocardId).price;
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
      this.configService.computer.videocardId = this.selectedvideocardId;
      this.configService.price = this.currentTotalPrice;
    }
  }

  goToRam() {
    this.configService.progress = this.configService.progress - 13;
    this.router.navigate(['/configurator/ram']);
  }

  goToStorage() {
    this.configService.computer.videocardId = this.selectedvideocardId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 15;
    this.router.navigate(['configurator/storage']);
  }

  getVideocardById(id: string) {
    if (id !== undefined) {
      return this.videocards.find(c => c.id === id);
    }
  }

  constructor(private router: Router, private configService: ConfigComputerService) {}

  ngOnInit() {
    this.configService.videocards
      .getAll(JSON.stringify(this.configService.computer))
      .subscribe(response => {
        this.videocards = response;
        this.currentTotalPrice = this.configService.price;
        if (this.configService.computer.videocardId !== '') {
          this.videocards.find(
            c => c.id === this.getVideocardById(this.configService.computer.videocardId).id
          ).isSelected = true;
          this.isDisabled = false;
        }
        this.selectedvideocardId = this.configService.computer.videocardId;
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
  }
}
