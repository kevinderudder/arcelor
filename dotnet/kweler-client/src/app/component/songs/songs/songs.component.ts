import { AuthenticationService } from './../../../services/authentication.service';
import { SongsService } from './../../../services/songs.service';
import { Component, OnInit } from '@angular/core';
import { Song } from '../../../models/song';

@Component({
  selector: 'app-songs',
  templateUrl: './songs.component.html',
  styleUrls: ['./songs.component.scss']
})
export class SongsComponent implements OnInit {

  songs:Song[];

  constructor(private songsService:SongsService, 
              private authService:AuthenticationService) { }

  loadSongs(){
    let token = this.authService.getToken().subscribe(res => {
        this.songsService.getAll().subscribe(res => {
        this.songs = res;
      });
  });

    console.info(token);
    
  }

  ngOnInit() {
    this.loadSongs();
  }

}
