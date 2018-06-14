import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Cooler } from '../../shared/models/cooler';

@Component({
  selector: 'app-cooler',
  templateUrl: './cooler.component.html',
  styleUrls: ['./cooler.component.css']
})
export class CoolerComponent implements OnInit {
  coolers: Cooler[];
  isDisabled = true;
  selectedCoolerId: string;
  currentTotalPrice: number;
  cpuHasStockCooler: boolean;

  coolerSelected($event) {
    if (this.selectedCoolerId === $event) {
      this.selectedCoolerId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getCoolerById($event).price;
    } else {
      for (let i = 0; i < this.coolers.length; i++) {
        if ($event !== this.coolers[i].id) {
          if (this.coolers[i].isSelected) {
            this.currentTotalPrice =
              this.currentTotalPrice - this.getCoolerById(this.coolers[i].id).price;
          }
          this.coolers[i].isSelected = false;
        }
      }
      this.selectedCoolerId = $event;
      this.isDisabled = false;
      this.currentTotalPrice =
        this.currentTotalPrice + this.getCoolerById(this.selectedCoolerId).price;
    }
  }

  goToCpu() {
    this.configService.progress = this.configService.progress - 14;
    this.router.navigate(['/configurator/cpu']);
  }

  goToMotherboard() {
    this.configService.computer.coolerId = this.selectedCoolerId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 14;
    this.router.navigate(['configurator/motherboard']);
  }

  getCoolerById(id: string) {
    if (id !== undefined) {
      return this.coolers.find(c => c.id === id);
    }
  }

  constructor(private router: Router, private configService: ConfigComputerService) {}

  ngOnInit() {
    this.configService.coolers
      .getAll(JSON.stringify(this.configService.computer))
      .subscribe(response => {
        this.coolers = response;
        this.currentTotalPrice = this.configService.price;

        if (this.configService.computer.coolerId !== '') {
          this.coolers.find(
            c => c.id === this.getCoolerById(this.configService.computer.coolerId).id
          ).isSelected = true;
          this.isDisabled = false;
        }
        this.selectedCoolerId = this.configService.computer.coolerId;
      });
    console.log(this.configService.computer);
     this.configService.cpus.getById(this.configService.computer.cpuId).subscribe(response => {
      this.cpuHasStockCooler = response.hasStockCooler;
      this.isDisabled = false;
    });
  }

}
