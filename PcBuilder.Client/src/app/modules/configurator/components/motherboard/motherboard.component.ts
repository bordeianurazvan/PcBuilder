import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';

@Component({
  selector: 'app-motherboard',
  templateUrl: './motherboard.component.html',
  styleUrls: ['./motherboard.component.css']
})
export class MotherboardComponent implements OnInit {
  motherboards: any[];
  isDisabled = true;
  selectedMoatherboardId: number;
  indexOfMotherboardAlreadySelected: any;
  currentTotalPrice: number;

  motherboardSelected($event) {
    if (this.selectedMoatherboardId === $event) {
      this.selectedMoatherboardId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getMotherboardById($event).price;
    } else {
      for (let i = 0; i < this.motherboards.length; i++) {
        if ($event !== this.motherboards[i].id) {
          if (this.motherboards[i].isSelected) {
            this.currentTotalPrice = this.currentTotalPrice - this.getMotherboardById(this.motherboards[i].id).price;
          }
          this.motherboards[i].isSelected = false;
        }
      }
      this.selectedMoatherboardId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = this.currentTotalPrice + this.getMotherboardById(this.selectedMoatherboardId).price;
    }
  }

  goToCooler() {
    this.configService.progress = this.configService.progress - 13;
    this.router.navigate(['/configurator/cooler']);
  }

  goToRam() {
    this.configService.computer.motherboardId = this.selectedMoatherboardId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 15;
    this.router.navigate(['configurator/ram']);
  }

  getMotherboardById(id: number) {
    if (id !== undefined) {
      return this.motherboards.find(c => c.id === id);
    }
  }

  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.currentTotalPrice = this.configService.price;
    this.motherboards = [
      {
        id: 1,
        title: 'GIGABYTE GA-H110-D3A',
        price: 330,
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
        title: 'MSI B350 TOMAHAWK',
        price: 450,
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
        title: 'GIGABYTE AORUS Z370 Gaming K3',
        price: 380,
        socket: '1151',
        motherboards: ['ATX', 'MTX'],
        fans: '2/6',
        slots: 7,
        cpuCoolerHeight: 180,
        videoCardWidth: 200,
        isSelected: false
      }
    ];
    if (this.configService.computer.motherboardId !== undefined) {
      this.indexOfMotherboardAlreadySelected = this.motherboards.find(
        c => c.id === this.configService.computer.motherboardId
      ).isSelected = true;
      if (this.indexOfMotherboardAlreadySelected !== undefined) {
        this.isDisabled = false;
      }
      this.selectedMoatherboardId = this.configService.computer.motherboardId;
    }
    console.log(this.configService.computer);
  }

}
