import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HeroListComponent } from './hero-list/hero-list.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { PokemonComponent } from './pokemon/pokemon.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [ //This will hold the reference to other component this application will need
    AppComponent, 
    HeroListComponent,
    PokemonComponent
  ],
  imports: [ //This is where we reference modules that we will need for this project
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([
      {path: "superhero", component: HeroListComponent},
      {path: "pokemon", component: PokemonComponent}
    ]),
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [], //This is where you reference services
  bootstrap: [AppComponent] //This is first loaded component/code in the angular application
})
export class AppModule { }
