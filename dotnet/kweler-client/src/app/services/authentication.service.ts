import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private httpClient:HttpClient) { }

  loadToken(){
    const url = "https://localhost:44369/api/token/createtoken";
    const headers= {
      headers: new HttpHeaders({
          'Content-Type': 'application/json'
      })
    };
    const body = JSON.stringify(
      {
        username: 'kevin',
        password: 'test123'
      }
    );
    return this.httpClient.post(url, body, headers);
  }

  getToken():any{
    if(sessionStorage.getItem("token")){
      return sessionStorage.getItem("token");
    }
    else{
      return this.loadToken().subscribe(res => {
       sessionStorage.setItem("token", JSON.stringify(res));
       return sessionStorage.getItem("token");
      });
    }

  }
}
