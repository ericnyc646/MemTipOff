import { Component, OnInit } from '@angular/core';

import { UserQuickSheetsModel } from '../../models/userquicksheets.model';
import { QuicksheetsioService } from '../../datalayer/quicksheetsio.service';

import { Router } from '@angular/router';
import {Subscription} from 'rxjs';

import { UserauthserviceService } from '../../datalayer/userauthservice.service';

@Component({
  selector: 'app-userdashboard',
  templateUrl: './userdashboard.component.html',
  styleUrls: ['./userdashboard.component.css']
})

export class UserdashboardComponent implements OnInit {
  subscription:Subscription;
  status: boolean;
  sheets: UserQuickSheetsModel[];

  constructor(private router: Router, 
    private userauthservice: UserauthserviceService, 
    private quicksheetioservice: QuicksheetsioService) { }

  ngOnInit() {
    this.subscription = this.userauthservice.authNavStatus$.subscribe(status => this.status = status);
    this.getUserSheets();
  }

  getUserSheets(): void {
    //this.quicksheetioservice.getUserSheets().subscribe(data => this.formatSheets(<UserQuickSheetsModel>data));
    this.quicksheetioservice.getUserSheets().subscribe(data => this.sheets = <UserQuickSheetsModel[]>data);
  }

}
