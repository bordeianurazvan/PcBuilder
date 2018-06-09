import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';

@Component({
  selector: 'app-powerSupply',
  templateUrl: './powerSupply.component.html',
  styleUrls: ['./powerSupply.component.css']
})
export class PowerSupplyComponent implements OnInit {
  powersupplies: any[];
  isDisabled = true;
  selectedPowersupplyId: number;
  indexOfPowersupplyAlreadySelected: any;
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

  getPowersupplyById(id: number) {
    if (id !== undefined) {
      return this.powersupplies.find(c => c.id === id);
    }
  }
  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.currentTotalPrice = this.configService.price;
    this.powersupplies = [
      {
        id: 1,
        title: 'Corsair NEW VS Series VS550',
        price: 95,
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
        title: 'Seasonic S12II-520 Bronze 520W',
        price: 85,
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
        title: 'Seasonic S12II-620 Bronze 620W',
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
    if (this.configService.computer.powersupplyId !== undefined) {
      this.indexOfPowersupplyAlreadySelected = this.powersupplies.find(
        c => c.id === this.configService.computer.powersupplyId
      ).isSelected = true;
      if (this.indexOfPowersupplyAlreadySelected !== undefined) {
        this.isDisabled = false;
      }
      this.selectedPowersupplyId = this.configService.computer.powersupplyId;
    }
    console.log(this.configService.computer);
  }

}
