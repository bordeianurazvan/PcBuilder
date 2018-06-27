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
import { Storage } from '../../shared/models/storage';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.css']
})
export class ResultComponent implements OnInit {
  case: Case = new Case();
  cpu: Cpu = new Cpu();
  cooler: Cooler = new Cooler();
  motherboard: Motherboard = new Motherboard();
  ram: Ram = new Ram();
  videocard: VideoCard = new VideoCard();
  storage: any = new Storage();
  powersupply: PowerSupply = new PowerSupply();
  totalPrice: number;

  constructor(private router: Router, private configService: ConfigComputerService) {
    this.case.isSelected = false;
    // this.case.imageUrl =
    //   'https://5.grgs.ro/images/products/1/1175151/1509310/full/sg-k8-black-e96126214d7b03f844ab330e1115b758.jpg';
    // this.case.title = 'Carcasa Segotep SG-K8 Black';
    // this.case.price = 269.99;
    // this.case.numberOfSlots = 7;
    // this.case.url = 'https://www.pcgarage.ro/carcase/segotep/sg-k8-black/';
    // this.case.coolerHeight = 200;
    // this.case.fans = 2;
    // this.case.motherboardFormFactor = ['ATX', 'mATX'];
    // this.case._motherboardFormFactor = ['ATX', 'mATX'];
    // this.case.totalFans = 3;
    // this.case.type = 'MiddleTower';
    this.cpu.isSelected = false;
    this.cooler.isSelected = false;
    this.motherboard.isSelected = false;
    this.ram.isSelected = false;
    this.videocard.isSelected = false;
    this.powersupply.isSelected = false;
    this.storage.isSelected = false;
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
    this.totalPrice = this.configService.price;
  }
}
