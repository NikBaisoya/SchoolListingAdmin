import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashBoardContentComponent } from '../../views/dash-board-content/dash-board-content.component'
import { AppSharedModule } from 'src/app/app-shared/modules/app-shared.module';

@NgModule({
  declarations: [DashBoardContentComponent],
  imports: [
    CommonModule,
    DashboardRoutingModule, AppSharedModule
  ]
})
export class DashboardModule { }
