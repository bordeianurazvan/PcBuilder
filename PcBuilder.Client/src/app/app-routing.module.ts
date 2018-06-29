import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './modules/core/components/home/home.component';
import { TutorialComponent } from './modules/core/components/tutorial/tutorial.component';
import { CommunityComponent } from './modules/core/components/community/community.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: 'configurator',
    loadChildren: './modules/configurator/configurator.module#ConfiguratorModule'
  },
  { path: 'tutorial', component: TutorialComponent },
  { path: 'community', component: CommunityComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],

  declarations: []
})
export class AppRoutingModule {}
