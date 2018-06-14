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
  selectedStorageId: string;
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

  getStorageById(id: string) {
    if (id !== undefined) {
      return this.storages.find(c => c.id === id);
    }
  }


  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.configService.storages.getAll(JSON.stringify(this.configService.computer)).subscribe(response => {
      this.storages = response;
      this.currentTotalPrice = this.configService.price;
      if (this.configService.computer.storageId !== '') {
        this.storages.find(
          c => c.id === this.getStorageById(this.configService.computer.storageId).id
        ).isSelected = true;
        this.isDisabled = false;
      }
      this.selectedStorageId = this.configService.computer.storageId;

    });
    console.log(this.configService.computer);
  }

}
