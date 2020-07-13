import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { DemoAppComponent } from './demo-app/demo-app.component';
import { appRoutes } from './routes';
import { FindMatchesService } from './_services/find-matches-service';
import { FooterComponent } from './footer/footer.component';
import { ConfiguredUrlsService } from './_services/configured-urls.service';


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    DemoAppComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    ReactiveFormsModule
  ],
  providers: [FindMatchesService, ConfiguredUrlsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
