import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HeroListComponent } from './hero-list/hero-list.component';

@NgModule({
  declarations: [ //This will hold the reference to other component this application will need
    AppComponent, 
    HeroListComponent
  ],
  imports: [ //This is where we reference modules that we will need for this project
    BrowserModule
  ],
  providers: [], //This is where you reference services
  bootstrap: [AppComponent] //This is first loaded component/code in the angular application
})
export class AppModule { }
