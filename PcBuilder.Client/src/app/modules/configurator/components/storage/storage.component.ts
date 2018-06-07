import { Component, OnInit } from '@angular/core';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-storage',
  templateUrl: './storage.component.html',
  styleUrls: ['./storage.component.css']
})
export class StorageComponent implements OnInit {
  storages: any[];
  isDisabled = true;
  selectedStorageId: number;
  indexOfStorageAlreadySelected: any;
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
      this.currentTotalPrice = this.currentTotalPrice + this.getStorageById(this.selectedStorageId).price;
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

  getStorageById(id: number) {
    if (id !== undefined) {
      return this.storages.find(c => c.id === id);
    }
  }


  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.currentTotalPrice = this.configService.price;
    this.storages = [
      {
        id: 1,
        title: 'Kingston SSDNow UV400 120GB SATA-III 2.5 inch',
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
        title: 'Samsung 860 EVO 250GB SATA-III 2.5 inch',
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
        title: 'WD Blue 1TB SATA-III 7200 RPM 64MB',
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
    if (this.configService.computer.storageId !== undefined) {
      this.indexOfStorageAlreadySelected = this.storages.find(
        c => c.id === this.configService.computer.storageId
      ).isSelected = true;
      if (this.indexOfStorageAlreadySelected !== undefined) {
        this.isDisabled = false;
      }
      this.selectedStorageId = this.configService.computer.storageId;
    }
    console.log(this.configService.computer);
  }

}
