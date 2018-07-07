import { Component, OnInit } from '@angular/core';
import { QuickSheetsModel } from '../../models/quicksheetsmodel.model';
import { QuicksheetsioService } from '../../datalayer/quicksheetsio.service';

@Component({
  selector: 'app-createquicksheet',
  templateUrl: './createquicksheet.component.html',
  styleUrls: ['./createquicksheet.component.css']
})
export class CreatequicksheetComponent implements OnInit {
  quicksheets: QuickSheetsModel[];
  elementtextarea = ' ';
  thetopicselected = '';
  theelementselected = 'ch-topic';

  alltopics = [];
  cheatsheetjson = {
      topics: []
  };

  constructor(private quicksheetioservice: QuicksheetsioService) { }

  ngOnInit() {
    this.quicksheets = this.quicksheetioservice.getAllSheets();
  }

  onElementChange(value: string) {
    //alert(value);
  }

  onAddClick() {
    this.elementtextarea = '';

    switch (this.theelementselected) {
      case "topicdiv":
          this.addTopic('');
          break;
      case "titlesectiondiv":
          this.addElement('', '');
          break;

    }
  }

  addTopic(title: string) {
    var index = this.alltopics.length + 1;
    this.alltopics.push(title + '|topicdiv' + index);
    this.cheatsheetjson.topics.push({ "name": "topicdiv" + index, "displayorder" : 0, "text" : title, elements: [] });
    this.reloadtopicsdropdown();
    this.updatejson();
  }

  addElement(title: string, topic: string) {
    for (var item in this.cheatsheetjson.topics) {
      if (this.cheatsheetjson.topics[item]['name'] == topic) {
          var displayorder = this.cheatsheetjson.topics[item]['elements'].length + 1;
          var name = topic + "_element" + displayorder;
          var element = { "name": name, "text": title, "type": this.theelementselected, "displayorder": displayorder };
          this.cheatsheetjson.topics[item]['elements'].push(element);
          this.updatejson();
          return;
      }

  }
  }

  reloadtopicsdropdown() {}

  updatejson() {}
}
