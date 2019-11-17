import { Component, OnInit } from '@angular/core';
import {BeerService} from '../../shared/services/beer.service';
import {Beer} from '../../shared/models/beers';
import {Form, FormControl, FormGroup} from '@angular/forms';
import {Router} from '@angular/router';

@Component({
  selector: 'app-beer-add',
  templateUrl: './beer-add.component.html',
  styleUrls: ['./beer-add.component.scss']
})
export class BeerAddComponent implements OnInit {

  beerForm = new FormGroup(
{
  id: new FormControl(''),
  navn: new FormControl('')
});
  constructor(private beerService: BeerService, private router: Router) {
  }

  beers: Beer[];

  ngOnInit() {
  }
  save() {
    const beer = this.beerForm.value;
    this.beerService.addBeer(beer).subscribe(() => {
      this.router.navigateByUrl('/beers');
    });
  }
}
