import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConfiguratorComponent } from './configurator.component';
import { ConfiguratorRoutes } from './configurator.routing';
import { ConfigNavComponent } from './components/config-nav/config-nav.component';
import { CaseComponent } from './components/case/case.component';
import { CpuComponent } from './components/cpu/cpu.component';
import { CoolerComponent } from './components/cooler/cooler.component';
import { MotherboardComponent } from './components/motherboard/motherboard.component';
import { RamComponent } from './components/ram/ram.component';
import { VideoCardComponent } from './components/videoCard/videoCard.component';
import { StorageComponent } from './components/storage/storage.component';
import { PowerSupplyComponent } from './components/powerSupply/powerSupply.component';
import { ConfigComputerService } from './shared/services/config-computer.service';
import { CaseCardComponent } from './shared/components/case-card/case-card.component';
import { CpuCardComponent } from './shared/components/cpu-card/cpu-card.component';
import { CoolerCardComponent } from './shared/components/cooler-card/cooler-card.component';
import { MotherboardCardComponent } from './shared/components/motherboard-card/motherboard-card.component';
import { RamCardComponent } from './shared/components/ram-card/ram-card.component';
import { VideocardCardComponent } from './shared/components/videocard-card/videocard-card.component';
import { StorageCardComponent } from './shared/components/storage-card/storage-card.component';
import { PowersupplyCardComponent } from './shared/components/powersupply-card/powersupply-card.component';
import { HttpClientModule } from '@angular/common/http';
import { ResultComponent } from './components/result/result.component';
import { CommunityService } from '../core/shared/services/community.service';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ConfiguratorRoutes,
    HttpClientModule
  ],
  declarations: [
    ConfiguratorComponent,
    ConfigNavComponent,
    CaseComponent,
    CpuComponent,
    CoolerComponent,
    MotherboardComponent,
    RamComponent,
    VideoCardComponent,
    StorageComponent,
    PowerSupplyComponent,
    CaseCardComponent,
    CpuCardComponent,
    CoolerCardComponent,
    MotherboardCardComponent,
    RamCardComponent,
    VideocardCardComponent,
    StorageCardComponent,
    PowersupplyCardComponent,
    ResultComponent
  ],
  providers: [ConfigComputerService, CommunityService]
})
export class ConfiguratorModule { }
