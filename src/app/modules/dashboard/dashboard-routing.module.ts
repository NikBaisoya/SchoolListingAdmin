import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashBoardContentComponent } from 'src/app/views/dash-board-content/dash-board-content.component';
const routes: Routes = [
  { path: '', component: DashBoardContentComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
