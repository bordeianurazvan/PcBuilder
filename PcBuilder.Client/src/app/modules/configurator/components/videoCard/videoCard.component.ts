import { Component, OnInit } from '@angular/core';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-videocard',
  templateUrl: './videoCard.component.html',
  styleUrls: ['./videoCard.component.css']
})
export class VideoCardComponent implements OnInit {
  videocards: any[];
  isDisabled = true;
  selectedvideocardId: number;
  indexOfVideocardAlreadySelected: any;
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
            this.currentTotalPrice = this.currentTotalPrice - this.getVideocardById(this.videocards[i].id).price;
          }
          this.videocards[i].isSelected = false;
        }
      }
      this.selectedvideocardId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = this.currentTotalPrice + this.getVideocardById(this.selectedvideocardId).price;
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

  getVideocardById(id: number) {
    if (id !== undefined) {
      return this.videocards.find(c => c.id === id);
    }
  }

  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.currentTotalPrice = this.configService.price;
    this.videocards = [
      {
        id: 1,
        title: 'Sapphire Radeon RX 580 PULSE 8GB DDR5 256-bit',
        price: 99,
        socket: '1151 v2',
        motherboards: ['ATX', 'MTX'],
        fans: '2/6',
        slots: 7,
        cpuCoolerHeight: 180,
        videoCardWidth: 200,
        isSelected: false
      },
      {
        id: 2,
        title: 'GIGABYTE Radeon RX Vega56 8G HBM2 GAMING OC',
        price: 100,
        socket: '1151',
        motherboards: ['ATX', 'MTX'],
        fans: '2/6',
        slots: 7,
        cpuCoolerHeight: 180,
        videoCardWidth: 200,
        isSelected: false
      },
      {
        id: 3,
        title: 'Inno3D GeForce GTX 1060 Twin X2 3GB DDR5 192-bit',
        price: 100,
        socket: '1151',
        motherboards: ['ATX', 'MTX'],
        fans: '2/6',
        slots: 7,
        cpuCoolerHeight: 180,
        videoCardWidth: 200,
        isSelected: false
      }
    ];
    if (this.configService.computer.videocardId !== undefined) {
      this.indexOfVideocardAlreadySelected = this.videocards.find(
        c => c.id === this.configService.computer.videocardId
      ).isSelected = true;
      if (this.indexOfVideocardAlreadySelected !== undefined) {
        this.isDisabled = false;
      }
      this.selectedvideocardId = this.configService.computer.videocardId;
    }
    console.log(this.configService.computer);
  }

}
