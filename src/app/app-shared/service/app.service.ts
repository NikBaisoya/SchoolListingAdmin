import { HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor() { }



  setLocalStorageItem(key: string, value: string) {
    localStorage.setItem(key, value);
  }

  getLocalStorageItem(key: string) {
    return localStorage.getItem(key);
  }


  getRequestHeader() {

    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };
    return new HttpHeaders({ 'Authorization': 'Bearer ' + localStorage.getItem("Token") });
  
  }




}
