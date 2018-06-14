import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Motherboard } from '../../shared/models/motherboard';

@Component({
  selector: 'app-motherboard',
  templateUrl: './motherboard.component.html',
  styleUrls: ['./motherboard.component.css']
})
export class MotherboardComponent implements OnInit {
  motherboards: Motherboard[];
  isDisabled = true;
  selectedMoatherboardId: string;
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
            this.currentTotalPrice =
              this.currentTotalPrice - this.getMotherboardById(this.motherboards[i].id).price;
          }
          this.motherboards[i].isSelected = false;
        }
      }
      this.selectedMoatherboardId = $event;
      this.isDisabled = false;
      this.currentTotalPrice =
        this.currentTotalPrice + this.getMotherboardById(this.selectedMoatherboardId).price;
    }
  }

  goToCooler() {
    this.configService.progress = this.configService.progress - 14;
    this.router.navigate(['/configurator/cooler']);
  }

  goToRam() {
    this.configService.computer.motherboardId = this.selectedMoatherboardId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 15;
    this.router.navigate(['configurator/ram']);
  }

  getMotherboardById(id: string) {
    if (id !== undefined) {
      return this.motherboards.find(c => c.id === id);
    }
  }

  constructor(private router: Router, private configService: ConfigComputerService) {}

  ngOnInit() {
    this.configService.motherboards.getAll(JSON.stringify(this.configService.computer)).subscribe(response => {
      this.motherboards = response;
      this.currentTotalPrice = this.configService.price;

      if (this.configService.computer.motherboardId !== '') {
        this.motherboards.find(
          c => c.id === this.getMotherboardById(this.configService.computer.motherboardId).id
        ).isSelected = true;
        this.isDisabled = false;
      }
      this.selectedMoatherboardId = this.configService.computer.motherboardId;
    });
    console.log(this.configService.computer);
  }
}
