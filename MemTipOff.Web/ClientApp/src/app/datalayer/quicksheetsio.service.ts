import { Injectable } from '@angular/core';
import { QuickSheetsModel } from '../models/quicksheetsmodel.model';
import { UserQuickSheetsModel } from '../models/userquicksheets.model';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class QuicksheetsioService {

  //qsheets: QuickSheetsModel[];


  constructor(private http: HttpClient) { }

  getAllSheets(): Observable<QuickSheetsModel> {
    return this.http.get<QuickSheetsModel>('/api/QuickSheets/1001');
  }

  getUserSheets(): Observable<UserQuickSheetsModel[]> {
    return this.http.get<UserQuickSheetsModel[]>('/api/UserQuickSheets');
  }

}
