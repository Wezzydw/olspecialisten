import { Component, OnInit } from '@angular/core';
import {BeerService} from '../../shared/services/beer.service';
import {FormControl, FormGroup} from '@angular/forms';
import {Router} from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  loginForm = new FormGroup(
      {
        name: new FormControl(''),
        password: new FormControl('')
      });
  constructor(private beerService: BeerService,
              private router: Router) { }

  ngOnInit() {
  }
    submit() {
        const user = this.loginForm.value;
        this.beerService.login(user).subscribe(beerUpdated => {
            this.router.navigateByUrl('/beers');
        });
    }
    logout() {
        this.beerService.logout();
    }

}
