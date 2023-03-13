import { Component } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { filter } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'SchoolListingAdmin';
  isShowHeader: boolean = false;
  constructor(private router: Router) {
  }



  ngOnInit() {
    this.router.events.pipe(filter((event: any) => event instanceof NavigationEnd)).subscribe((event: any) => {
      this.isShowHeader = (event.url !== '/login' && event.url !== '/') ? true : false;

    });
  }



}
