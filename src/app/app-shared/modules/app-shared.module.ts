import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import { MatTableModule } from '@angular/material/table'



@NgModule({
  declarations: [],
  imports: [
    CommonModule, HttpClientModule, ReactiveFormsModule, FormsModule,
    MatInputModule, MatButtonModule, MatCardModule, MatIconModule,MatTableModule
  ],
  exports: [
    CommonModule, HttpClientModule, ReactiveFormsModule, FormsModule,
    MatInputModule, MatButtonModule, MatCardModule, MatIconModule,MatTableModule
  ],
})
export class AppSharedModule { }
