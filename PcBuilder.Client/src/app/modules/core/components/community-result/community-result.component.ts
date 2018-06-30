import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Case } from '../../../configurator/shared/models/case';
import { Cpu } from '../../../configurator/shared/models/cpu';
import { Cooler } from '../../../configurator/shared/models/cooler';
import { Ram } from '../../../configurator/shared/models/ram';
import { Motherboard } from '../../../configurator/shared/models/motherboard';
import { VideoCard } from '../../../configurator/shared/models/videoCard';
import { PowerSupply } from '../../../configurator/shared/models/powerSupply';
import { ConfigComputerService } from '../../../configurator/shared/services/config-computer.service';
import { CommunityService } from '../../shared/services/community.service';
import { Storage } from '../../../configurator/shared/models/storage';
import { Post } from '../../shared/models/post';

@Component({
  selector: 'app-community-result',
  templateUrl: './community-result.component.html',
  styleUrls: ['./community-result.component.css']
})
export class CommunityResultComponent implements OnInit {
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

  // tslint:disable-next-line:max-line-length
  constructor(
    private router: Router,
    private communityService: CommunityService,
    private route: ActivatedRoute,
    private configService: ConfigComputerService
  ) {
    this.case.isSelected = false;
    this.cpu.isSelected = false;
    this.cooler.isSelected = false;
    this.motherboard.isSelected = false;
    this.ram.isSelected = false;
    this.videocard.isSelected = false;
    this.powersupply.isSelected = false;
    this.storage.isSelected = false;
  }
  back() {
    this.router.navigate(['community']);
  }
  buy(product: any) {
    console.log(product);
    window.open(product.url);
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.communityService.posts.getById(params['id']).subscribe(response => {
        this.post = response;
        this.totalPrice = this.post.price;
        this.post.title = response.title;
        this.post.description = response.description;

        this.configService.cases.getById(response.caseId).subscribe(responseCase => {
          this.case = responseCase;
        });

        this.configService.cpus.getById(response.cpuId).subscribe(responseCpu => {
          this.cpu = responseCpu;
        });

        if (response.coolerId !== '' && response.coolerId != null) {
          this.configService.coolers.getById(response.coolerId).subscribe(responseCooler => {
            this.cooler = responseCooler;
          });
        }

        this.configService.motherboards
          .getById(response.motherboardId)
          .subscribe(responseMotherboard => {
            this.motherboard = responseMotherboard;
          });

        this.configService.rams.getById(response.ramId).subscribe(reponseRam => {
          this.ram = reponseRam;
        });

        this.configService.videocards.getById(response.videoCardId).subscribe(responseVideocard => {
          this.videocard = responseVideocard;
        });

        this.configService.storages.getById(response.storageId).subscribe(responseStorage => {
          this.storage = responseStorage;
        });

        this.configService.powersupplies
          .getById(response.powerSupplyId)
          .subscribe(responsePowersupply => {
            this.powersupply = responsePowersupply;
          });
      });
    });
  }
}
