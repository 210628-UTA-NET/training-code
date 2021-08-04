import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { IPokemon } from '../services/poke';
import { PokeapiService } from "../services/pokeapi.service";

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})
export class PokemonComponent implements OnInit {

  currentPokemon: IPokemon;

  pokeGroup = new FormGroup({
    id: new FormControl(),
    name: new FormControl()
  });

  constructor(private pokeApi: PokeapiService) { }

  ngOnInit(): void {
    let temp: IPokemon =
    {
      name:"No Current Pokemon",
      base_experience:0,
      id:0,
      sprites: []
    }

    this.currentPokemon = temp;
  }

  getPikachu()
  {
    this.pokeApi.getPikachu().subscribe((response) => {
      this.currentPokemon.name = response.name;
      this.currentPokemon.base_experience = response.base_experience;
      this.currentPokemon.id = response.id;
      this.currentPokemon.sprites = response.sprites;
      console.log(this.currentPokemon);
    });
  }

  getPokemon(pokeGroup: FormGroup)
  {
    if (pokeGroup.get("id").value) 
    {
      this.pokeApi.getPokemon(pokeGroup.get("id").value).subscribe(
        (response) => {
          this.currentPokemon.name = response.name;
          this.currentPokemon.base_experience = response.base_experience;
          this.currentPokemon.id = response.id;
          this.currentPokemon.sprites = response.sprites;
        }
      )
    }
  }
}
