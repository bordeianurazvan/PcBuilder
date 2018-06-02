import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './components/home/home.component';
import { RouterModule } from '@angular/router';
import { TutorialComponent } from './components/tutorial/tutorial.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule
  ],
  exports: [],
  declarations:  [HomeComponent, TutorialComponent]
})
export class CoreModule { }
