import { Component, OnInit } from '@angular/core';

import { QuickSheetsModel } from '../../models/quicksheetsmodel.model';
import { QuicksheetsioService } from '../../datalayer/quicksheetsio.service';

import { Router } from '@angular/router';
import {Subscription} from 'rxjs';

import { UserauthserviceService } from '../../datalayer/userauthservice.service';

@Component({
  selector: 'app-viewquicksheet',
  templateUrl: './viewquicksheet.component.html',
  styleUrls: ['./viewquicksheet.component.css']
})
export class ViewquicksheetComponent implements OnInit {
  quicksheets = JSON.parse('{ "topics": [] }');
  title : string;
  description: string;
  attribution: string;
  status: boolean;
  subscription:Subscription;

  constructor(private router: Router, 
    private userauthservice: UserauthserviceService, 
    private quicksheetioservice: QuicksheetsioService) {

   }

  ngOnInit() {
    this.subscription = this.userauthservice.authNavStatus$.subscribe(status => this.status = status);
    this.getSheet();
  }

  getSheet(): void {
    this.quicksheetioservice.getAllSheets().subscribe(data => this.formatJSON(data));
  }

  formatJSON(data: any) {
    var thesheet = <QuickSheetsModel>data;
    this.title = thesheet.title;
    this.description = thesheet.description;
    this.attribution = thesheet.attribution;
    var thejson = thesheet.json;
    this.quicksheets = JSON.parse(thejson);
  }
}
