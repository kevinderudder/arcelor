import { ParkingService } from './../../services/parking.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Parking } from '../../models/parking';

@Component({
  selector: 'app-parking-info',
  templateUrl: './parking-info.component.html',
  styleUrls: ['./parking-info.component.scss']
})
export class ParkingInfoComponent implements OnInit {
  parking:Parking;
  id: string;
  constructor(private route: ActivatedRoute, private parkingService:ParkingService){
	  route.params.subscribe(params => {this.id = params['id']});
  }

  loadParking(id){
    this.parkingService.loadParking(this.id)
                       .subscribe((resp:Parking) => {
                          this.parking = resp;
                       });
  }

  ngOnInit() {
    this.loadParking(this.id);
  }

}
