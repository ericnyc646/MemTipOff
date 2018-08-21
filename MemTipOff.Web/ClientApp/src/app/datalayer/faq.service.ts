import { Injectable } from '@angular/core';
import { FAQs, FAQentries  } from '../models/faq.model';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FaqService {

  constructor(private http: HttpClient) { }

  getAllFaqs(): Observable<FAQentries> {
    return this.http.get<FAQentries>('/api/FAQ');
  }
}
