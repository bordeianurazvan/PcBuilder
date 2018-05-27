import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConfiguratorComponent } from './configurator.component';
import { ConfiguratorRoutes } from './configurator.routing';
import { ConfigNavComponent } from './components/config-nav/config-nav.component';
import { CaseComponent } from './components/case/case.component';

@NgModule({
  imports: [
    CommonModule,
    ConfiguratorRoutes
  ],
  declarations: [
    ConfiguratorComponent,
    ConfigNavComponent,
    CaseComponent
  ]
})
export class ConfiguratorModule { }
