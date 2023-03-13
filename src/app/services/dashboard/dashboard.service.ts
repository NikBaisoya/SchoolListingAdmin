import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { AppService } from 'src/app/app-shared/service/app.service';


@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  public apiUrl: string = environment.apiUrl;
  constructor(private httpClient: HttpClient, private appService: AppService) { }


  getMySchoolsList() {
    let headers = this.appService.getRequestHeader();
    return this.httpClient.get<any>(this.apiUrl + "School/MySchoolsListGet", { headers: headers })
  }



}
