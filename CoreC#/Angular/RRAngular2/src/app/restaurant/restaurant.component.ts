import { Component, OnInit } from '@angular/core';
import { IRestaurant } from '../services/restaurant';
import { RrapiService } from "../services/rrapi.service";

@Component({
  selector: 'app-restaurant',
  templateUrl: './restaurant.component.html',
  styleUrls: ['./restaurant.component.css']
})
export class RestaurantComponent implements OnInit {

  restaurants: IRestaurant[];

  constructor(private RRApi:RrapiService) { }

  ngOnInit(): void {
    
    this.RRApi.getAllRestaurant().subscribe(
      (response) => {
        this.restaurants = response;
      }
    );
  }

}
