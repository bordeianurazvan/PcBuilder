import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Case } from '../../shared/models/case';
import { Cpu } from '../../shared/models/cpu';
import { Cooler } from '../../shared/models/cooler';
import { Motherboard } from '../../shared/models/motherboard';
import { Ram } from '../../shared/models/ram';
import { VideoCard } from '../../shared/models/videoCard';
import { PowerSupply } from '../../shared/models/powerSupply';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.css']
})
export class ResultComponent implements OnInit {
  case: Case = new Case();
  cpu: Cpu;
  cooler: Cooler;
  motherboard: Motherboard;
  ram: Ram;
  videocard: VideoCard;
  storage: Storage;
  powersupply: PowerSupply;

  constructor(private router: Router, private configService: ConfigComputerService) {
    this.case.isSelected = false;
  }

  ngOnInit() {
    if (this.configService.computer.caseId != null) {
      this.configService.cases.getById(this.configService.computer.caseId).subscribe(response => {
        this.case = response;
        console.log(this.case);
      });
    }

    if (this.configService.computer.cpuId != null) {
      this.configService.cpus.getById(this.configService.computer.cpuId).subscribe(response => {
        this.cpu = response;
        console.log(response);
      });
    }

    if (this.configService.computer.coolerId != null) {
      this.configService.coolers
        .getById(this.configService.computer.coolerId)
        .subscribe(response => {
          this.cooler = response;
          console.log(response);
        });
    }

    if (this.configService.computer.motherboardId != null) {
      this.configService.motherboards
        .getById(this.configService.computer.motherboardId)
        .subscribe(response => {
          this.motherboard = response;
          console.log(response);
        });
    }

    if (this.configService.computer.ramId != null) {
      this.configService.rams.getById(this.configService.computer.ramId).subscribe(response => {
        this.ram = response;
        console.log(response);
      });
    }

    if (this.configService.computer.storageId != null) {
      this.configService.storages
        .getById(this.configService.computer.storageId)
        .subscribe(response => {
          this.storage = response;
          console.log(response);
        });
    }

    if (this.configService.computer.videocardId != null) {
      this.configService.videocards
        .getById(this.configService.computer.videocardId)
        .subscribe(response => {
          this.videocard = response;
          console.log(response);
        });
    }

    if (this.configService.computer.powersupplyId != null) {
      this.configService.powersupplies
        .getById(this.configService.computer.powersupplyId)
        .subscribe(response => {
          this.powersupply = response;
          console.log(response);
        });
    }
  }
}
