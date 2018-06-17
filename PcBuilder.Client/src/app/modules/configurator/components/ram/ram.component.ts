import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Ram } from '../../shared/models/ram';
import { Motherboard } from '../../shared/models/motherboard';
import { Cooler } from '../../shared/models/cooler';
import { Cpu } from '../../shared/models/cpu';
import { Case } from '../../shared/models/case';
import { Computer } from '../../shared/models/Computer';

@Component({
  selector: 'app-ram',
  templateUrl: './ram.component.html',
  styleUrls: ['./ram.component.css']
})
export class RamComponent implements OnInit {
  motherboardSelected: Motherboard;
  coolerSelected: Cooler;
  cpuSelected: Cpu;
  caseSelected: Case;
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
      this.currentTotalPrice =
        this.caseSelected.price +
        this.cpuSelected.price +
        this.motherboardSelected.price +
        this.getRamById(this.selectedRamId).price;
      if (this.coolerSelected != null) {
        this.currentTotalPrice = this.currentTotalPrice + this.coolerSelected.price;
      }

      this.configService.computer = new Computer();
      this.configService.computer.caseId = this.caseSelected.id;
      this.configService.computer.cpuId = this.cpuSelected.id;

      if (this.coolerSelected != null) {
        this.configService.computer.coolerId = this.coolerSelected.id;
      }

      this.configService.computer.motherboardId = this.motherboardSelected.id;
      this.configService.computer.ramId = this.selectedRamId;
      this.configService.price = this.currentTotalPrice;
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

    this.configService.cases.getById(this.configService.computer.caseId).subscribe(response => {
      this.caseSelected = response;
    });

    this.configService.cpus.getById(this.configService.computer.cpuId).subscribe(response => {
      this.cpuSelected = response;
    });

    if (this.configService.computer.coolerId !== '') {
      this.configService.coolers
        .getById(this.configService.computer.coolerId)
        .subscribe(response => {
          this.coolerSelected = response;
        });
    }

    this.configService.motherboards
      .getById(this.configService.computer.motherboardId)
      .subscribe(response => {
        this.motherboardSelected = response;
      });
  }
}
