import { Song } from './../models/song';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SongsService {

  constructor(private httpClient:HttpClient) { }

  getAll(){
    const url:string = "https://localhost:44369/api/songs";
    return this.httpClient.get<Song[]>(url);
  }


}
