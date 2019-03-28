import { Photo } from './../../models/photo';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-photo-details',
  templateUrl: './photo-details.component.html',
  styleUrls: ['./photo-details.component.scss']
})
export class PhotoDetailsComponent implements OnInit {

  /*
    url:string = "https://picsum.photos/g/500?random";
    title:string = "A random photo";
  */

  photo:Photo = new Photo("https://picsum.photos/g/500?random", "A random photo");

  constructor() { }

  ngOnInit() {
  }

}
