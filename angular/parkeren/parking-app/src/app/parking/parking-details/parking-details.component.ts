import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { Parking } from '../../models/parking';
import { Router } from '@angular/router';

@Component({
  selector: 'app-parking-details',
  templateUrl: './parking-details.component.html',
  styleUrls: ['./parking-details.component.scss']
})
export class ParkingDetailsComponent implements OnInit {

  /*parking:Parking = new Parking(
    1,
    "Sint-Pietersplein",
    "Sint-Pietersplein",
    567,
    88,
    true,
    "sint-pietersplein 66, 9000 Gent"
  );*/

  @Input() parking:Parking;
  @Output() remove: EventEmitter<Parking>;

  constructor(private router:Router) {

    this.remove = new EventEmitter();

   }

  removeParking(){
    this.remove.emit(this.parking);
  }
  
  isFull(){
    return this.parking.availableCapacity === 0;
  }

  isWarning(){
    return (this.parking.availableCapacity / this.parking.totalCapacity) < .1;
  }

  goToDetails(){
    this.router.navigate([`/details/${this.parking.id}`])
  }

  ngOnInit() {
  }

}
