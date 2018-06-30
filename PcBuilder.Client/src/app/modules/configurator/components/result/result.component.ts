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
  titlePost: string;
  descriptionPost: string;

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
    this.post.title = this.titlePost;
    this.post.description = this.descriptionPost;

    this.communityService.posts.insert(this.post).subscribe(response => {
      this.post = response;
      this.router.navigate(['community']);
    },
  error => {
    console.log('error');
  });
  }

  buy(product: any) {
    console.log(product);
    window.open(product.url);
  }

  ngOnInit() {
    if (this.configService.computer.caseId != null) {
      this.configService.cases.getById(this.configService.computer.caseId).subscribe(response => {
        this.case = response;
        this.post.caseId = response.id;
        this.post.image = response.imageUrl;
        console.log(this.case);
      });
    }

    if (this.configService.computer.cpuId != null) {
      this.configService.cpus.getById(this.configService.computer.cpuId).subscribe(response => {
        this.cpu = response;
        this.post.cpuId = response.id;
        console.log(response);
      });
    }

    if (this.configService.computer.coolerId != null && this.configService.computer.coolerId !== '') {
      this.configService.coolers
        .getById(this.configService.computer.coolerId)
        .subscribe(response => {
          this.cooler = response;
          this.post.coolerId = response.id;
          console.log(response);
        });
    }

    if (this.configService.computer.motherboardId != null) {
      this.configService.motherboards
        .getById(this.configService.computer.motherboardId)
        .subscribe(response => {
          this.motherboard = response;
          this.post.motherboardId = response.id;
          console.log(response);
        });
    }

    if (this.configService.computer.ramId != null) {
      this.configService.rams.getById(this.configService.computer.ramId).subscribe(response => {
        this.ram = response;
        this.post.ramId = response.id;
        console.log(response);
      });
    }

    if (this.configService.computer.storageId != null) {
      this.configService.storages
        .getById(this.configService.computer.storageId)
        .subscribe(response => {
          this.storage = response;
          this.post.storageId = response.id;
          console.log(response);
        });
    }

    if (this.configService.computer.videocardId != null) {
      this.configService.videocards
        .getById(this.configService.computer.videocardId)
        .subscribe(response => {
          this.videocard = response;
          this.post.videoCardId = response.id;
          console.log(response);
        });
    }

    if (this.configService.computer.powersupplyId != null) {
      this.configService.powersupplies
        .getById(this.configService.computer.powersupplyId)
        .subscribe(response => {
          this.powersupply = response;
          this.post.powerSupplyId = response.id;
          console.log(response);
        });
    }
    this.totalPrice = this.configService.price;

    this.post.price = this.totalPrice;
  }
}
