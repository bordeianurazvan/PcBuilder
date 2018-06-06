import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';

@Component({
  selector: 'app-ram',
  templateUrl: './ram.component.html',
  styleUrls: ['./ram.component.css']
})
export class RamComponent implements OnInit {
  rams: any[];
  isDisabled = true;
  selectedRamId: number;
  indexOfRamAlreadySelected: any;
  currentTotalPrice: number;

  ramSelected($event) {
    if (this.selectedRamId === $event) {
      this.selectedRamId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getRamById($event).price;
    } else {
      for (let i = 0; i < this.rams.length; i++) {
        if ($event !== this.rams[i].id) {
          if (this.rams[i].isSelected) {
            this.currentTotalPrice = this.currentTotalPrice - this.getRamById(this.rams[i].id).price;
          }
          this.rams[i].isSelected = false;
        }
      }
      this.selectedRamId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = this.currentTotalPrice + this.getRamById(this.selectedRamId).price;
    }
  }

  goToMotherboard() {
    this.configService.progress = this.configService.progress - 15;
    this.router.navigate(['/configurator/motherboard']);
  }

  goToVideocard() {
    this.configService.computer.ramId = this.selectedRamId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 13;
    this.router.navigate(['configurator/videocard']);
  }

  getRamById(id: number) {
    if (id !== undefined) {
      return this.rams.find(c => c.id === id);
    }
  }
  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.currentTotalPrice = this.configService.price;
    this.rams = [
      {
        id: 1,
        title: 'HyperX Fury Black 8GB DDR4 2400MHz CL15 1.2v',
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
        title: 'ADATA Premier 4GB DDR4 2400MHz CL17 1.2v',
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
        title: 'Patriot Viper Elite Red 8GB DDR4 2400MHz CL15 1.2v Dual Channel Kit',
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
    if (this.configService.computer.ramId !== undefined) {
      this.indexOfRamAlreadySelected = this.rams.find(
        c => c.id === this.configService.computer.ramId
      ).isSelected = true;
      if (this.indexOfRamAlreadySelected !== undefined) {
        this.isDisabled = false;
      }
      this.selectedRamId = this.configService.computer.ramId;
    }
    console.log(this.configService.computer);
  }

}
