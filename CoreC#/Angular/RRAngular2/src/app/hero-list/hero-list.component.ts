import { Component, OnInit } from '@angular/core';
import { ISuperhero } from "./hero";

@Component({
  selector: 'app-hero-list',
  templateUrl: './hero-list.component.html',
  styleUrls: ['./hero-list.component.css']
})
export class HeroListComponent implements OnInit {

  heros:ISuperhero[]
  isVisible: boolean = true;

  constructor() 
  {
    this.heros = [{ //Hard coded values to add in our ISuperhero array
      name: 'Frozone',
      rank: 4,
      ability: 'cold generation',
      organization: 'incredibles',
      image: 'http://www.cultjer.com/img/ug_photo/2014_03/sf2_lg20140331142439.jpg'
  },
  {
      name: 'Eraser Head',
      rank: 5,
      ability: 'power nullification',
      organization: 'pro hero',
      image: 'https://media.tenor.co/images/788cc935108fb487b6af1e152bcec6bf/raw'
  },
  {
      name: 'Static Shock',
      rank: 4.7,
      ability: 'electric manipulation',
      organization: 'duo',
      image: 'https://t00.deviantart.net/CsfqTmmnwQAltUe4HYS8A7gsk-s=/300x200/filters:fixed_height(100,100)' +
          ':origin()/pre00/64ea/th/pre/f/2012/125/4/1/static_shock_by_deshockwav-d4ynm1o.png'
  },
  {
      name: 'Saitama',
      rank: 2.3,
      ability: 'punches',
      organization: 'the hero association',
      image: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTnx0maPoLAqImOmsoTnxRwBronngiLYfeOVYFSSs2UBLsjXDDT&s'
  }];
  }

  ngOnInit(): void {
  }

  toggleImage()
  {
    this.isVisible = !this.isVisible;
  }
}
