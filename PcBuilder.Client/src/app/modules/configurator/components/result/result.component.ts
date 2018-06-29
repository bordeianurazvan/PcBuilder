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
import { CommunityService } from '../../../core/shared/services/community.service';
import { Post } from '../../../core/shared/models/post';

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
  post: Post;

  constructor(
    private router: Router,
    private configService: ConfigComputerService,
    private communityService: CommunityService
  ) {
    this.case.isSelected = false;
    this.cpu.isSelected = false;
    this.cooler.isSelected = false;
    this.motherboard.isSelected = false;
    this.ram.isSelected = false;
    this.videocard.isSelected = false;
    this.powersupply.isSelected = false;
    this.storage.isSelected = false;
    this. post = new Post();
  }
  share() {
    this.communityService.posts.insert(this.post).subscribe(response => {
      this.post = response;
    },
  error => {
    console.log('error');
  });
    console.log(this.post);
    this.router.navigate(['community']);
  }

  ngOnInit() {
    if (this.configService.computer.caseId != null) {
      this.configService.cases.getById(this.configService.computer.caseId).subscribe(response => {
        this.case = response;
        this.post.CaseId = response.id;
        this.post.image = response.imageUrl;
        console.log(this.case);
      });
    }

    if (this.configService.computer.cpuId != null) {
      this.configService.cpus.getById(this.configService.computer.cpuId).subscribe(response => {
        this.cpu = response;
        this.post.CpuId = response.id;
        console.log(response);
      });
    }

    if (this.configService.computer.coolerId != null && this.configService.computer.coolerId !== '') {
      this.configService.coolers
        .getById(this.configService.computer.coolerId)
        .subscribe(response => {
          this.cooler = response;
          this.post.CoolerId = response.id;
          console.log(response);
        });
    }

    if (this.configService.computer.motherboardId != null) {
      this.configService.motherboards
        .getById(this.configService.computer.motherboardId)
        .subscribe(response => {
          this.motherboard = response;
          this.post.MotherboardId = response.id;
          console.log(response);
        });
    }

    if (this.configService.computer.ramId != null) {
      this.configService.rams.getById(this.configService.computer.ramId).subscribe(response => {
        this.ram = response;
        this.post.RamId = response.id;
        console.log(response);
      });
    }

    if (this.configService.computer.storageId != null) {
      this.configService.storages
        .getById(this.configService.computer.storageId)
        .subscribe(response => {
          this.storage = response;
          this.post.StorageId = response.id;
          console.log(response);
        });
    }

    if (this.configService.computer.videocardId != null) {
      this.configService.videocards
        .getById(this.configService.computer.videocardId)
        .subscribe(response => {
          this.videocard = response;
          this.post.VideoCardId = response.id;
          console.log(response);
        });
    }

    if (this.configService.computer.powersupplyId != null) {
      this.configService.powersupplies
        .getById(this.configService.computer.powersupplyId)
        .subscribe(response => {
          this.powersupply = response;
          this.post.PowerSupplyId = response.id;
          console.log(response);
        });
    }
    this.totalPrice = this.configService.price;

    this.post.price = this.totalPrice;
    this.post.description = 'description';
    this.post.title = 'title';
  }
}
