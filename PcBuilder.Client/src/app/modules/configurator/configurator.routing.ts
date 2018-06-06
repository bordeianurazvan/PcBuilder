import { Routes, RouterModule } from '@angular/router';
import { ConfiguratorComponent } from './configurator.component';
import { CaseComponent } from './components/case/case.component';
import { CpuComponent } from './components/cpu/cpu.component';
import { CoolerComponent } from './components/cooler/cooler.component';
import { MotherboardComponent } from './components/motherboard/motherboard.component';
import { RamComponent } from './components/ram/ram.component';
import { VideoCardComponent } from './components/videoCard/videoCard.component';
import { StorageComponent } from './components/storage/storage.component';
import { PowerSupplyComponent } from './components/powerSupply/powerSupply.component';

const routes: Routes = [
  {
    path: '',
    component: ConfiguratorComponent,
    children: [
      { path: 'case', component: CaseComponent },
      { path: 'cpu', component: CpuComponent },
      { path: 'cooler', component: CoolerComponent },
      { path: 'motherboard', component: MotherboardComponent },
      { path: 'ram', component: RamComponent },
      { path: 'videocard', component: VideoCardComponent },
      { path: 'storage', component: StorageComponent },
      { path: 'powerSupply', component: PowerSupplyComponent }
    ]
  }
];

export const ConfiguratorRoutes = RouterModule.forChild(routes);
