import { Component, OnInit } from '@angular/core';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cpu',
  templateUrl: './cpu.component.html',
  styleUrls: ['./cpu.component.css']
})
export class CpuComponent implements OnInit {
  cpus: any[];
  isDisabled = true;
  selectedCpuId: number;
  indexOfCpuAlreadySelected: any;
  currentTotalPrice: number;

  cpuSelected($event) {
    if (this.selectedCpuId === $event) {
      this.selectedCpuId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getCpuById($event).price;
    } else {
      for (let i = 0; i < this.cpus.length; i++) {
        if ($event !== this.cpus[i].id) {
          if (this.cpus[i].isSelected) {
            this.currentTotalPrice = this.currentTotalPrice - this.getCpuById(this.cpus[i].id).price;
          }
          this.cpus[i].isSelected = false;
        }
      }
      this.selectedCpuId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = this.currentTotalPrice + this.getCpuById(this.selectedCpuId).price;
    }
  }

  goToCase() {
    this.configService.progress = this.configService.progress - 13;
    this.router.navigate(['/configurator/case']);
  }

  goToCpuCooler() {
    this.configService.computer.cpuId = this.selectedCpuId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 14;
    this.router.navigate(['configurator/cooler']);
  }

  getCpuById(id: number) {
    if (id !== undefined) {
      return this.cpus.find(c => c.id === id);
    }
  }


  constructor(private router: Router, private configService: ConfigComputerService) {}

  ngOnInit() {
    this.currentTotalPrice = this.configService.price;
    this.cpus = [
      {
        id: 1,
        title: 'Intel Coffee Lake, Core i7 8700K 3.70GHz',
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
        title: 'Intel Coffee Lake, Core i5 8400 2.80GHz box',
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
        title: 'Intel Kaby Lake, Celeron Dual-Core G3930 2.90GHz box',
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
    if (this.configService.computer.cpuId !== undefined) {
      this.indexOfCpuAlreadySelected = this.cpus.find(
        c => c.id === this.configService.computer.cpuId
      ).isSelected = true;
      if (this.indexOfCpuAlreadySelected !== undefined) {
        this.isDisabled = false;
      }
      this.selectedCpuId = this.configService.computer.cpuId;
    }
    console.log(this.configService.computer);
  }
}
