import { Component, OnInit } from '@angular/core';

import { QuickSheetsModel } from '../../models/quicksheetsmodel.model';
import { QuicksheetsioService } from '../../datalayer/quicksheetsio.service';

import { Router } from '@angular/router';
import {Subscription} from 'rxjs';

import { UserauthserviceService } from '../../datalayer/userauthservice.service';

@Component({
  selector: 'app-createquicksheet',
  templateUrl: './createquicksheet.component.html',
  styleUrls: ['./createquicksheet.component.css']
})
export class CreatequicksheetComponent implements OnInit {
  quicksheets = JSON.parse('{ "topics": [] }');
  elementtextarea = ' ';
  thetopicselected = '';
  topictobindto: string = '';
  theelementselected = 'ch-topic';
  datafromcall = null;
  //alltopics = [];
  cheatsheetjson: string;
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
    this.quicksheetioservice.getAllSheets().subscribe(data => this.formatJSON((<QuickSheetsModel>data).json));
  }

  onElementChange(value: string) {
    //alert(value);
  }

  onAddClick() {
    switch (this.theelementselected) {
      case "ch-topic":
          this.addTopic(this.elementtextarea);
          break;
      default:
          this.addElement(this.elementtextarea, this.topictobindto);
          break;

    }
    
  }

  formatJSON(thejson: string) {
    this.cheatsheetjson = thejson;
    this.quicksheets = JSON.parse(thejson);
  }

  addTopic(title: string) {
    var index = this.quicksheets.topics.length + 1;
    this.quicksheets.topics.push({ "name": "topicdiv" + index, "displayorder" : 0, "text" : title, elements: [] });
  }

  addElement(title: string, topic: string) {
    for (var item in this.quicksheets.topics) {
      if(this.quicksheets.topics[item]['name'] == topic) {
        var displayorder = this.quicksheets.topics[item]['elements'].length + 1;
        var name = topic + "_element" + displayorder;
        var element = { "name": name, "text": title, "type": this.theelementselected, "displayorder": displayorder };
        this.quicksheets.topics[item]['elements'].push(element);
        return;
      }
    }
  }


}
