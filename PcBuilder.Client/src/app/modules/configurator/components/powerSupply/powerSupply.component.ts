import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { PowerSupply } from '../../shared/models/powerSupply';

@Component({
  selector: 'app-powersupply',
  templateUrl: './powerSupply.component.html',
  styleUrls: ['./powerSupply.component.css']
})
export class PowerSupplyComponent implements OnInit {
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
            this.currentTotalPrice = this.currentTotalPrice - this.getPowersupplyById(this.powersupplies[i].id).price;
          }
          this.powersupplies[i].isSelected = false;
        }
      }
      this.selectedPowersupplyId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = this.currentTotalPrice + this.getPowersupplyById(this.selectedPowersupplyId).price;
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
  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.configService.powersupplies.getAll(JSON.stringify(this.configService.computer)).subscribe(response => {
      this.powersupplies = response;
      this.currentTotalPrice = this.configService.price;
      if (this.configService.computer.motherboardId !== '') {
        this.powersupplies.find(
          c => c.id === this.getPowersupplyById(this.configService.computer.powersupplyId).id
        ).isSelected = true;
        this.isDisabled = false;
      }
      this.selectedPowersupplyId = this.configService.computer.powersupplyId;
    });
    console.log(this.configService.computer);
  }

}
