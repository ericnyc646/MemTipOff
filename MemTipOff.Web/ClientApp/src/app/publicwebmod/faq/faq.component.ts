import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {Subscription} from 'rxjs';

import { UserauthserviceService } from '../../datalayer/userauthservice.service';
import { FaqService  } from '../../datalayer/faq.service';
import { FAQs } from '../../models/faq.model'

@Component({
  selector: 'app-faq',
  templateUrl: './faq.component.html',
  styleUrls: ['./faq.component.css']
})
export class FaqComponent implements OnInit {
  status: boolean;
  subscription:Subscription;

  faqsdata: FAQs[];

  constructor(private router: Router, 
    private userauthservice: UserauthserviceService, 
    private faqservice: FaqService) { }

  ngOnInit() {
    this.subscription = this.userauthservice.authNavStatus$.subscribe(status => this.status = status);
    this.getFAQ();
  }

  getFAQ(): void {
    this.faqservice.getAllFaqs().subscribe(data => this.showData(data));
  }

  showData(data: object): void {
    //console.log(data);
    this.faqsdata = <FAQs[]>data;
    console.log(JSON.stringify(this.faqsdata));
  }

}
