import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './modules/core/components/home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'configurator', loadChildren: './modules/configurator/configurator.module#ConfiguratorModule' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],

  declarations: []
})
export class AppRoutingModule {}
