import { Component, OnInit } from '@angular/core';
import {Beer} from '../../shared/models/beers';
import {BeerService} from '../../shared/services/beer.service';

@Component({
  selector: 'app-beer-list',
  templateUrl: './beer-list.component.html',
  styleUrls: ['./beer-list.component.scss']
})
export class BeerListComponent implements OnInit {

  beers: Beer[];

  constructor(private beerService: BeerService ) {}

  ngOnInit() {
    this.refresh();
  }
  refresh() {
    this.beerService.getBeers().subscribe(listOfBeers => this.beers = listOfBeers);
  }
  delete(id: number) {
    this.beerService.deleteBeer(id).subscribe(message => {
      console.log('Deleted user, got message: ' + message);
      this.refresh();
    });
  }
}
