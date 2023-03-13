import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};
@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {


  public apiUrl: string = environment.apiUrl;
  constructor(private httpClient: HttpClient) { }


  authenticateUser(userAuthentication: any) {
    return this.httpClient.post<any>(this.apiUrl + "Login/AuthenticateUser", userAuthentication, httpOptions)
  }



}
