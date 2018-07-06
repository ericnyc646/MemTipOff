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
  theelementselected = 'ch-topic';

  constructor(private quicksheetioservice: QuicksheetsioService) { }

  ngOnInit() {
    this.quicksheets = this.quicksheetioservice.getAllSheets();
  }

  onElementChange(value: string) {
    //alert(value);
  }

}
