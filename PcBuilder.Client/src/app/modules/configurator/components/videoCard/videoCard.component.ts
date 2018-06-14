import { Component, OnInit } from '@angular/core';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Router } from '@angular/router';
import { VideoCard } from '../../shared/models/videoCard';

@Component({
  selector: 'app-videocard',
  templateUrl: './videoCard.component.html',
  styleUrls: ['./videoCard.component.css']
})
export class VideoCardComponent implements OnInit {
  videocards: VideoCard[];
  isDisabled = true;
  selectedvideocardId: string;
  currentTotalPrice: number;

  videocardSelected($event) {
    if (this.selectedvideocardId === $event) {
      this.selectedvideocardId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getVideocardById($event).price;
    } else {
      for (let i = 0; i < this.videocards.length; i++) {
        if ($event !== this.videocards[i].id) {
          if (this.videocards[i].isSelected) {
            this.currentTotalPrice = this.currentTotalPrice - this.getVideocardById(this.videocards[i].id).price;
          }
          this.videocards[i].isSelected = false;
        }
      }
      this.selectedvideocardId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = this.currentTotalPrice + this.getVideocardById(this.selectedvideocardId).price;
    }
  }


  goToRam() {
    this.configService.progress = this.configService.progress - 13;
    this.router.navigate(['/configurator/ram']);
  }

  goToStorage() {
    this.configService.computer.videocardId = this.selectedvideocardId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 15;
    this.router.navigate(['configurator/storage']);
  }

  getVideocardById(id: string) {
    if (id !== undefined) {
      return this.videocards.find(c => c.id === id);
    }
  }

  constructor(private router: Router, private configService: ConfigComputerService) { }

  ngOnInit() {
    this.configService.videocards.getAll(JSON.stringify(this.configService.computer)).subscribe(response => {
      this.videocards = response;
      this.currentTotalPrice = this.configService.price;
      if (this.configService.computer.videocardId !== '') {
        this.videocards.find(
          c => c.id === this.getVideocardById(this.configService.computer.videocardId).id
        ).isSelected = true;
        this.isDisabled = false;
      }
      this.selectedvideocardId = this.configService.computer.videocardId;
    });

    console.log(this.configService.computer);
  }

}
