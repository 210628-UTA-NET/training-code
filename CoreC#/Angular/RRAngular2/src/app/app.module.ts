import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";

import { AppComponent } from './app.component';
import { HeroListComponent } from './hero-list/hero-list.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { PokemonComponent } from './pokemon/pokemon.component';
import { HttpClientModule } from '@angular/common/http';
import { RestaurantComponent } from './restaurant/restaurant.component';

@NgModule({
  declarations: [ //This will hold the reference to other component this application will need
    AppComponent, 
    HeroListComponent,
    PokemonComponent,
    RestaurantComponent
  ],
  imports: [ //This is where we reference modules that we will need for this project
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([
      {path: "superhero", component: HeroListComponent},
      {path: "pokemon", component: PokemonComponent},
      {path: "restaurant", component: RestaurantComponent},
      {path: "**", redirectTo:"superhero"}
    ]),
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule
  ],
  providers: [], //This is where you reference services
  bootstrap: [AppComponent] //This is first loaded component/code in the angular application
})
export class AppModule { }
