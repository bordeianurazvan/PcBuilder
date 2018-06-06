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

@NgModule({
  imports: [
    CommonModule,
    ConfiguratorRoutes
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
    CoolerCardComponent

  ],
  providers: [ConfigComputerService]
})
export class ConfiguratorModule { }
