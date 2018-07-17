import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserdashboardComponent } from './userdashboard/userdashboard.component';
import { MyquicksheetsComponent } from './myquicksheets/myquicksheets.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [UserdashboardComponent, MyquicksheetsComponent]
})
export class UserwebmodModule { }
