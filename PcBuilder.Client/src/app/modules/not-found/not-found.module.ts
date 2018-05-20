import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NotFoundComponent } from './not-found.component';
import { NotFoundRoutes } from './not-found.routing';

@NgModule({
  imports: [
    CommonModule,
    NotFoundRoutes
  ],
  declarations: [NotFoundComponent]
})
export class NotFoundModule { }
