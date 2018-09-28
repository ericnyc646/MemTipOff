import { Component, OnInit } from '@angular/core';

import { UserQuickSheetsModel } from '../../models/userquicksheets.model';
import { QuicksheetsioService } from '../../datalayer/quicksheetsio.service';
import { PageParametersService } from '../../datalayer/pageparameters.service';

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
  sheettoview: string;

  sheetidselected: string;

  constructor(private router: Router, 
    private userauthservice: UserauthserviceService, 
    private quicksheetioservice: QuicksheetsioService,
    private pageparamservice: PageParametersService) { 
      //this.pageparamservice.usersheetselectedtoview.subscribe((sheetid: string) => this.sheettoview = sheetid);

    }

  ngOnInit() {
    this.subscription = this.userauthservice.authNavStatus$.subscribe(status => this.status = status);
    this.pageparamservice.usersheetselectedtoview.subscribe(data => this.sheettoview = data);
    this.getUserSheets();
  }

  getUserSheets(): void {
    //this.quicksheetioservice.getUserSheets().subscribe(data => this.formatSheets(<UserQuickSheetsModel>data));
    this.quicksheetioservice.getUserSheets().subscribe(data => this.sheets = <UserQuickSheetsModel[]>data);
  }

  sheetselected(sheetid: string): void {
    console.log(sheetid);
    //this.pageparamservice.usersheetselectedtoview.emit(sheetid);
    this.pageparamservice.changeUserSelectedSheet(sheetid);
    this.router.navigate(['/authors/viewsheet']);
  }

}
