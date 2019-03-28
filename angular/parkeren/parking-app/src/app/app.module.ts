import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ParkingDetailsComponent } from './parking/parking-details/parking-details.component';
import { ParkingListComponent } from './parking/parking-list/parking-list.component';

import {  HttpClientModule, HttpClient } from '@angular/common/http';
import { ParkingInfoComponent } from './parking/parking-info/parking-info.component';

import { FormsModule } from '@angular/forms';
import { ParkingPipe } from './pipes/parking.pipe';
@NgModule({
  declarations: [
    AppComponent,
    ParkingDetailsComponent,
    ParkingListComponent,
    ParkingInfoComponent,
    ParkingPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
