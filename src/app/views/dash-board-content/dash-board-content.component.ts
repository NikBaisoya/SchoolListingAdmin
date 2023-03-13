import { Component, OnInit } from '@angular/core';
import { DashboardService } from 'src/app/services/dashboard/dashboard.service';
import { MatTableDataSource } from '@angular/material/table'
import { _MatPaginatorBase } from '@angular/material/paginator';
@Component({
  selector: 'app-dash-board-content',
  templateUrl: './dash-board-content.component.html',
  styleUrls: ['./dash-board-content.component.scss']
})
export class DashBoardContentComponent implements OnInit {

  public schoolList = new Array<any>();

  public dataSoruce: any;
  displayedColumns: string[] = ['schoolName', 'createdOn', 'status'];




  constructor(private dashboardService: DashboardService) { }

  ngOnInit(): void {
    debugger;
    this.getMySchoolsList();
  }


  getMySchoolsList() {
    debugger;
    this.dashboardService.getMySchoolsList().subscribe((response: any) => {
      debugger;
      if (response.statuCode == 200) {
        this.schoolList = response.data;
        this.dataSoruce = new MatTableDataSource(this.schoolList);
      }

    });



  }

  deletedata(schoolData: any) {

  }

}
