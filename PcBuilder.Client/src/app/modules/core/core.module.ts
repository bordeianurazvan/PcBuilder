import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './components/home/home.component';
import { RouterModule } from '@angular/router';
import { TutorialComponent } from './components/tutorial/tutorial.component';
import { CommunityComponent } from './components/community/community.component';
import { HttpClientModule } from '@angular/common/http';
import { CommunityService } from './shared/services/community.service';
import { CommunityResultComponent } from './components/community-result/community-result.component';
import { ConfigComputerService } from '../configurator/shared/services/config-computer.service';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    HttpClientModule
  ],
  exports: [],
  declarations:  [HomeComponent, TutorialComponent, CommunityComponent, CommunityResultComponent],
  providers: [CommunityService, ConfigComputerService]
})
export class CoreModule { }
