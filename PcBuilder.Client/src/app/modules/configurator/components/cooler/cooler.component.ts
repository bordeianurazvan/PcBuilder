import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';

@Component({
  selector: 'app-cooler',
  templateUrl: './cooler.component.html',
  styleUrls: ['./cooler.component.css']
})
export class CoolerComponent implements OnInit {
  coolers: any[];
  isDisabled = true;
  selectedCoolerId: number;
  indexOfCoolerAlreadySelected: any;
  currentTotalPrice: number;

  coolerSelected($event) {
    if (this.selectedCoolerId === $event) {
      this.selectedCoolerId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getCoolerById($event).price;
    } else {
      for (let i = 0; i < this.coolers.length; i++) {
        if ($event !== this.coolers[i].id) {
          if (this.coolers[i].isSelected) {
            this.currentTotalPrice = this.currentTotalPrice - this.getCoolerById(this.coolers[i].id).price;
          }
          this.coolers[i].isSelected = false;
        }
      }
      this.selectedCoolerId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = this.currentTotalPrice + this.getCoolerById(this.selectedCoolerId).price;
    }
  }


  goToCpu() {
    this.configService.progress = this.configService.progress - 13;
    this.router.navigate(['/configurator/cpu']);
  }

  goToMotherboard() {
    this.configService.computer.coolerId = this.selectedCoolerId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 13;
    this.router.navigate(['configurator/motherboard']);
  }

  getCoolerById(id: number) {
    if (id !== undefined) {
      return this.coolers.find(c => c.id === id);
    }
  }

  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.currentTotalPrice = this.configService.price;
    this.coolers = [
      {
        id: 1,
        title: 'Deepcool GAMMAXX 200T',
        price: 50,
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
        title: 'Noctua NH-D14',
        price: 23,
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
        title: 'Noctua NH-D15',
        price: 115,
        socket: '1151',
        motherboards: ['ATX', 'MTX'],
        fans: '2/6',
        slots: 7,
        cpuCoolerHeight: 180,
        videoCardWidth: 200,
        isSelected: false
      }
    ];
    if (this.configService.computer.coolerId !== undefined) {
      this.indexOfCoolerAlreadySelected = this.coolers.find(
        c => c.id === this.configService.computer.coolerId
      ).isSelected = true;
      if (this.indexOfCoolerAlreadySelected !== undefined) {
        this.isDisabled = false;
      }
      this.selectedCoolerId = this.configService.computer.coolerId;
    }
    console.log(this.configService.computer);
  }

}
