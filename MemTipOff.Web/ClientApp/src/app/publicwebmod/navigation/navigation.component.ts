import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {Subscription} from 'rxjs';

import { UserauthserviceService } from '../../datalayer/userauthservice.service';


@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {
  status: boolean;
  subscription:Subscription;
  name: string;

  constructor(private router: Router, private userauthservice: UserauthserviceService) { }

  ngOnInit() {
    this.subscription = this.userauthservice.authNavStatus$.subscribe(status => this.status = status);
  }

  logout() {
    this.userauthservice.logout();
    
  }

  getuserinfo() {
    this.userauthservice.getUserDetails()
    .subscribe(data => { this.processuserinfo(data) });
  }

  processuserinfo(data) {
    this.name = 'Welcome ' + data.firstName;
  }
}
