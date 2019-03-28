import { Pipe, PipeTransform } from '@angular/core';
import { Parking } from '../models/parking';

@Pipe({
  name: 'parkingFilter'
})
export class ParkingPipe implements PipeTransform {

  transform(parkings: Parking[], args: any = ""): any {
    if(!parkings) return;
    if(args == "") return parkings;

    return parkings.filter(
      p => p.name.toLowerCase().indexOf(args.toLowerCase()) !== -1
    );
  }

}
