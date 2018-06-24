import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { NotFoundModule } from './modules/not-found/not-found.module';
import { AppRoutingModule } from './app-routing.module';
import { CoreModule } from './modules/core/core.module';


@NgModule({
  declarations: [
    AppComponent,
],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CoreModule,
    NotFoundModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
