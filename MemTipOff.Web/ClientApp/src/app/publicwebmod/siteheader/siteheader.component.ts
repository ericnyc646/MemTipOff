import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {Subscription} from 'rxjs';

import { UserauthserviceService } from '../../datalayer/userauthservice.service';

@Component({
  selector: 'app-siteheader',
  templateUrl: './siteheader.component.html',
  styleUrls: ['./siteheader.component.css']
})
export class SiteheaderComponent implements OnInit {
  status: boolean;
  subscription:Subscription;

  constructor(private router: Router, private userauthservice: UserauthserviceService) { }

  ngOnInit() {
    this.subscription = this.userauthservice.authNavStatus$.subscribe(status => this.status = status);
  }

}
