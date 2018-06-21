import { Component, OnInit } from '@angular/core';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Router } from '@angular/router';
import { Cpu } from '../../shared/models/cpu';
import { Computer } from '../../shared/models/Computer';
import { Case } from '../../shared/models/case';

@Component({
  selector: 'app-cpu',
  templateUrl: './cpu.component.html',
  styleUrls: ['./cpu.component.css']
})
export class CpuComponent implements OnInit {
  cpus: Cpu[];
  isDisabled = true;
  selectedCpuId: string;
  currentTotalPrice: number;
  caseSelected: Case;

  cpuSelected($event) {
    if (this.selectedCpuId === $event) {
      this.selectedCpuId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getCpuById($event).price;
    } else {
      for (let i = 0; i < this.cpus.length; i++) {
        if ($event !== this.cpus[i].id) {
          if (this.cpus[i].isSelected) {
            this.currentTotalPrice =
              this.currentTotalPrice - this.getCpuById(this.cpus[i].id).price;
          }
          this.cpus[i].isSelected = false;
        }
      }
      this.selectedCpuId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = this.caseSelected.price + this.getCpuById(this.selectedCpuId).price;

      this.configService.computer = new Computer();
      this.configService.computer.caseId = this.caseSelected.id;
      this.configService.computer.cpuId = this.selectedCpuId;
      this.configService.price = this.currentTotalPrice;
    }
  }

  goToCase() {
    this.configService.progress = this.configService.progress - 13;
    this.router.navigate(['/configurator/case']);
  }

  goToCpuCooler() {
    this.configService.computer.cpuId = this.selectedCpuId;
    this.configService.progress = this.configService.progress + 14;
    this.configService.price = this.currentTotalPrice;
    this.router.navigate(['configurator/cooler']);
  }

  getCpuById(id: string) {
    if (id !== undefined) {
      return this.cpus.find(c => c.id === id);
    }
  }

  constructor(private router: Router, private configService: ConfigComputerService) {}

  ngOnInit() {
    this.configService.cpus
      .getAll(JSON.stringify(this.configService.computer))
      .subscribe(response => {
        this.cpus = response;
        this.currentTotalPrice = this.configService.price;
        if (this.configService.computer.cpuId !== '') {
          this.cpus.find(
            c => c.id === this.getCpuById(this.configService.computer.cpuId).id
          ).isSelected = true;
          this.isDisabled = false;
        }
        this.selectedCpuId = this.configService.computer.cpuId;
      });

    this.configService.cases.getById(this.configService.computer.caseId).subscribe(response => {
      this.caseSelected = response;
    });
    console.log(this.configService.computer);
  }
}
