import { Component, OnInit } from '@angular/core';
import {Beer} from '../../shared/models/beers';
import {BeerService} from '../../shared/services/beer.service';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-beer-details',
  templateUrl: './beer-details.component.html',
  styleUrls: ['./beer-details.component.scss']
})
export class BeerDetailsComponent implements OnInit {
  beer: Beer;

  constructor(private beerService: BeerService,
              private route: ActivatedRoute) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.beerService.getBeersById(id).subscribe(beerFromRest => this.beer = beerFromRest);
      }
}
