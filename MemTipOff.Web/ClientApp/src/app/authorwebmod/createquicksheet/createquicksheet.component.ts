import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { QuickSheetsModel } from '../../models/quicksheetsmodel.model';
import { QuicksheetsioService } from '../../datalayer/quicksheetsio.service';

@Component({
  selector: 'app-createquicksheet',
  templateUrl: './createquicksheet.component.html',
  styleUrls: ['./createquicksheet.component.css']
})
export class CreatequicksheetComponent implements OnInit {
  quicksheets = JSON.parse('{ "topics": [] }');
  elementtextarea = ' ';
  thetopicselected = '';
  theelementselected = 'ch-topic';
  datafromcall = null;
  //alltopics = [];
  cheatsheetjson: string;

  

  constructor(private quicksheetioservice: QuicksheetsioService, private http: HttpClient) {

   }

  ngOnInit() {
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
          this.addElement('', '');
          break;

    }
    
  }

  formatJSON(thejson: string) {
    this.cheatsheetjson = thejson;
    this.quicksheets = JSON.parse(thejson);
    //console.log(this.quicksheets);
  }

  addTopic(title: string) {
    var index = this.quicksheets.topics.length + 1;
    //this.alltopics.push(title + '|topicdiv' + index);
    this.quicksheets.topics.push({ "name": "topicdiv" + index, "displayorder" : 0, "text" : title, elements: [] });
    this.cheatsheetjson = JSON.stringify(this.quicksheets);
    this.reloadtopicsdropdown();
    this.updatejson();
  }

  addElement(title: string, topic: string) {
  //   for (var item in this.cheatsheetjson.topics) {
  //     if (this.cheatsheetjson.topics[item]['name'] == topic) {
  //         var displayorder = this.cheatsheetjson.topics[item]['elements'].length + 1;
  //         var name = topic + "_element" + displayorder;
  //         var element = { "name": name, "text": title, "type": this.theelementselected, "displayorder": displayorder };
  //         this.cheatsheetjson.topics[item]['elements'].push(element);
  //         this.updatejson();
  //         return;
  //     }

  // }
  }

  reloadtopicsdropdown() {}

  updatejson() {}
}
