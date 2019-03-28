import { Parking } from './../models/parking';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ParkingService {

  url:string = "https://datatank.stad.gent/4/mobiliteit/bezettingparkingsrealtime.json";
  parkings:Parking[];

  constructor(private http:HttpClient) { }
  
  loadParkings(){
    return this.http.get<Parking>(this.url)
                    .pipe(
                       map((result:any) => {
                          let parkings:Parking[] = [];
                          for(let i = 0 , l = result.length ; i < l ; i++){
                            let p = result[i];
                            let newP = new Parking(
                                p.id,
                                p.name,
                                p.name,
                                p.parkingStatus.totalCapacity,
                                p.parkingStatus.availableCapacity,
                                p.parkingStatus.open,
                                p.address
                            );
                          parkings.push(newP);
                          }

                          return parkings;
                       })
                    );
  }

  loadParking(id){
    return this.http.get<Parking>(this.url)
                    .pipe(
                       map((result:any) => {
                          let parkings:Parking[] = [];
                          for(let i = 0 , l = result.length ; i < l ; i++){
                            let p = result[i];
                            let newP = new Parking(
                                p.id,
                                p.name,
                                p.name,
                                p.parkingStatus.totalCapacity,
                                p.parkingStatus.availableCapacity,
                                p.parkingStatus.open,
                                p.address
                            );

                            if(newP.id == id){
                              return newP;
                            }
                         
                          }

                         
                       })
                    );
  }

  /*loadParkings():Parking[]{
    this.parkings = [];
    this.parkings.push(new Parking(
      1,
      "Sint Pieters",
      "Sint Pieters",
      400,
      88,
      true,
      ""
    ));
    this.parkings.push(new Parking(
      2,
      "Vrijdagmarkt",
      "Vrijdagmarkt",
      400,
      88,
      true,
      ""
    ));
    this.parkings.push(new Parking(
      3,
      "Reep",
      "Reep",
      400,
      88,
      true,
      ""
    ));

    return this.parkings;
  }*/
}
