import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BeerListComponent } from './beers/beer-list/beer-list.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { BeerDetailsComponent } from './beers/beer-details/beer-details.component';
import { BeerAddComponent } from './beers/beer-add/beer-add.component';
import {ReactiveFormsModule} from '@angular/forms';
import { BeerUpdateComponent } from './beers/beer-update/beer-update.component';
import {HttpClientModule} from '@angular/common/http';
import { LoginComponent } from './beers/login/login.component';
import {AuthGuard} from './beers/guard/auth.guard';

@NgModule({
  declarations: [
    AppComponent,
    BeerListComponent,
    NavbarComponent,
    WelcomeComponent,
    BeerDetailsComponent,
    BeerAddComponent,
    BeerUpdateComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
      HttpClientModule
  ],
  providers: [AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
