import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {WelcomeComponent} from './welcome/welcome.component';
import {BeerListComponent} from './beers/beer-list/beer-list.component';
import {BeerDetailsComponent} from './beers/beer-details/beer-details.component';
import {BeerAddComponent} from './beers/beer-add/beer-add.component';
import {BeerUpdateComponent} from './beers/beer-update/beer-update.component';
import {LoginComponent} from './beers/login/login.component';
import {AuthGuard} from './beers/guard/auth.guard';


const routes: Routes = [
  {path: 'beers', component: BeerListComponent},
  {path: 'beers/:id', component: BeerDetailsComponent, canActivate: [AuthGuard]},
  {path: 'beer-update/:id', component: BeerUpdateComponent, canActivate: [AuthGuard]},
  {path: 'beer-add', component: BeerAddComponent, canActivate: [AuthGuard]},
  {path: '', component: WelcomeComponent},
  {path: 'login', component: LoginComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
