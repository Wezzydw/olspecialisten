import { Injectable } from '@angular/core';
import {Beer} from '../models/beers';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {User} from '../models/users';
import {Token} from '@angular/compiler';
import {AuthenticationService} from './authentication.service';

const httpOptions = {
  headers: new HttpHeaders(
      {
        'Content-Type': 'application/json',
        Authorization: 'my-auth-token'
      })
};

@Injectable({
  providedIn: 'root'
})
export class BeerService {
  beers: Beer[];
  localUrl = 'http://192.168.0.30:7500/api/beer';
  externalUrl = 'http://wuzz.synology.me:7500/api/beer';
  localTokenUrl = 'http://192.168.0.30:7500/api/token';
  externalTokenUrl = 'http://wuzz.synology.me:7500/api/token';
  debugUrlToken = 'http://localhost:59327/api/token';
  debugUrl = 'http://localhost:59327/api/beer';
  tokenUrl = this.debugUrlToken;
  url = this.localUrl;



  constructor(private http: HttpClient, private authenticationService: AuthenticationService) {
    this.beers = [{id: 1, navn: 'tester'},
      {id: 2, navn: 'tester2'}];
  }
  getBeers(): Observable<Beer[]> {
    return this.http.get<Beer[]>(this.url);
  }

  updateBeer(beer: Beer): Observable<Beer> {
    httpOptions.headers = httpOptions.headers.set('Authorization', 'Bearer ' + this.authenticationService.getToken());
    return this.http.put<Beer>(this.url, beer, httpOptions);
  }

  addBeer(beer: Beer): Observable<Beer> {
    httpOptions.headers = httpOptions.headers.set('Authorization', 'Bearer ' + this.authenticationService.getToken());
    return this.http.post<Beer>(this.url, beer, httpOptions);
  }
  getBeersById(id: number): Observable<Beer> {
    httpOptions.headers = httpOptions.headers.set('Authorization', 'Bearer ' + this.authenticationService.getToken());
    return this.http.get<Beer>(this.url + '/' + id, httpOptions);
  }

  deleteBeer(id: number): Observable<any> {
    httpOptions.headers = httpOptions.headers.set('Authorization', 'Bearer ' + this.authenticationService.getToken());
    return this.http.delete(this.url + '/' + id, httpOptions);
  }

  login(user: User): Observable<any> {
    return this.authenticationService.login(user.name, user.password);
  }

  logout() {
    this.authenticationService.logout();
  }

}
