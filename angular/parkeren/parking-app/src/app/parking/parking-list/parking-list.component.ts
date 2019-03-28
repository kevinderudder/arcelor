import { ParkingPipe } from './../../pipes/parking.pipe';
import { ParkingService } from './../../services/parking.service';
import { Parking } from './../../models/parking';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parking-list',
  providers: [ParkingPipe],
  templateUrl: './parking-list.component.html',
  styleUrls: ['./parking-list.component.scss']
})
export class ParkingListComponent implements OnInit {

  parkings:Parking[];
  filter:string = "";

  constructor(private parkingService:ParkingService) { }

  loadParkings(){
    //this.parkings = this.parkingService.loadParkings();

    this.parkingService.loadParkings()
                       .subscribe((resp:Parking[]) => {
                          this.parkings = resp;
                       });

  }

  removeParking(parking:Parking){
    this.parkings.splice(this.parkings.indexOf(parking), 1);
  }

  addParking(name:string, availableCapacity:number, totalCapacity:number){
    let newParking:Parking = new Parking(this.parkings.length + 1
                                       , name
                                       , name
                                       , totalCapacity
                                       , availableCapacity
                                       , true
                                       , name);
    this.parkings.push(newParking);
  }
  

  ngOnInit() {
    this.loadParkings();
  }

}
