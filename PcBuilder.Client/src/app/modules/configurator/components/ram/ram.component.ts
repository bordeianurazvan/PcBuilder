import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Ram } from '../../shared/models/ram';

@Component({
  selector: 'app-ram',
  templateUrl: './ram.component.html',
  styleUrls: ['./ram.component.css']
})
export class RamComponent implements OnInit {
  rams: Ram[];
  isDisabled = true;
  selectedRamId: string;
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
            this.currentTotalPrice =
              this.currentTotalPrice - this.getRamById(this.rams[i].id).price;
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

  getRamById(id: string) {
    if (id !== undefined) {
      return this.rams.find(c => c.id === id);
    }
  }
  constructor(private router: Router, private configService: ConfigComputerService) {}

  ngOnInit() {
    this.configService.rams
      .getAll(JSON.stringify(this.configService.computer))
      .subscribe(response => {
        this.rams = response;
        this.currentTotalPrice = this.configService.price;
        if (this.configService.computer.ramId !== '') {
          this.rams.find(
            c => c.id === this.getRamById(this.configService.computer.ramId).id
          ).isSelected = true;
          this.isDisabled = false;
        }
        this.selectedRamId = this.configService.computer.ramId;
      });
    console.log(this.configService.computer);
  }
}
