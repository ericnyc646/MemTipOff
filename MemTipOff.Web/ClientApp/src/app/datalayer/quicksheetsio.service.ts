import { Injectable } from '@angular/core';
import { QuickSheetsModel } from '../models/quicksheetsmodel.model';

@Injectable({
  providedIn: 'root'
})

export class QuicksheetsioService {

  private qsheets: QuickSheetsModel[] = 
    [
      {
        "id": 1001,
        "title": "Angular 2+",
        "author": "Cestero, Eric",
        "description": "",
        "attribution": "",
        "json": ""
      }
    ];



  constructor() { }

  getAllSheets() {
    //we use an empty slice to return a new array instead
    //of a reference to the source array
    return this.qsheets.slice();
  }
}
