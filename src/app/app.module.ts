import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from '../app/views/login-component/login.component';
import { AppSharedModule } from './app-shared/modules/app-shared.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DashboardComponent } from './views/dashboard/dashboard.component'
@NgModule({
  declarations: [
    AppComponent, LoginComponent,DashboardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
    , AppSharedModule, BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
