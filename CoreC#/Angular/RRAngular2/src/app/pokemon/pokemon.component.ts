import { Component, OnInit } from '@angular/core';
import { IPokemon } from '../services/poke';
import { PokeapiService } from "../services/pokeapi.service";

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})
export class PokemonComponent implements OnInit {

  currentPokemon: IPokemon;

  constructor(private pokeApi: PokeapiService) { }

  ngOnInit(): void {
    let temp: IPokemon =
    {
      name:"No Current Pokemon",
      base_experience:0,
      front_default:"",
      id:0
    }
    
    this.currentPokemon = temp;
  }

  getPikachu()
  {
    this.pokeApi.getPikachu().subscribe((response) => {
      this.currentPokemon.name = response.name;
      this.currentPokemon.front_default = response.front_default;
      this.currentPokemon.base_experience = response.base_experience;
      this.currentPokemon.id = response.id;
      console.log(this.currentPokemon);
    });
  }
}
