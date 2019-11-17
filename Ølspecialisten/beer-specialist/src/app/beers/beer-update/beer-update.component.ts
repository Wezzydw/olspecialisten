import { Component, OnInit } from '@angular/core';
import {BeerService} from '../../shared/services/beer.service';
import {ActivatedRoute, Router} from '@angular/router';
import {FormControl, FormGroup} from '@angular/forms';

@Component({
  selector: 'app-beer-update',
  templateUrl: './beer-update.component.html',
  styleUrls: ['./beer-update.component.scss']
})
export class BeerUpdateComponent implements OnInit {
  id: number;
  beerForm = new FormGroup(
    {
      id: new FormControl(''),
      navn: new FormControl('')
    });
  constructor(private beerService: BeerService,
              private route: ActivatedRoute,
              private router: Router) { }

  ngOnInit() {
    this.id = +this.route.snapshot.paramMap.get('id');

    this.beerService.getBeersById(this.id).subscribe(beerFromRest => this.beerForm.patchValue(
        {
          id: beerFromRest.id,
          navn: beerFromRest.navn,
        }
    ));
    const beer = this.beerService.getBeersById(this.id);

  }
  save() {
    const beer = this.beerForm.value;
    beer.id = this.id;
    this.beerService.updateBeer(beer).subscribe(beerUpdated => {
      this.router.navigateByUrl('/beers');
    });
  }

}
