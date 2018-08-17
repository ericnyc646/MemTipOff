import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {Subscription} from 'rxjs';

import { UserauthserviceService } from '../../datalayer/userauthservice.service';

@Component({
  selector: 'app-authorsettings',
  templateUrl: './authorsettings.component.html',
  styleUrls: ['./authorsettings.component.css']
})
export class AuthorsettingsComponent implements OnInit {
  status: boolean;
  subscription:Subscription;

  constructor(private router: Router, private userauthservice: UserauthserviceService) { }

  ngOnInit() {
    this.subscription = this.userauthservice.authNavStatus$.subscribe(status => this.status = status);
  }

}
