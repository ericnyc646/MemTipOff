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
  isloggedin: boolean;
  status: boolean;
  subscription:Subscription;

  constructor(private router: Router, private userauthservice: UserauthserviceService) { }

  ngOnInit() {
    this.subscription = this.userauthservice.authNavStatus$.subscribe(status => this.status = status);
    this.isloggedin = this.userauthservice.isLoggedIn();
  }

  logout() {
    this.userauthservice.logout();
    this.isloggedin = this.userauthservice.isLoggedIn();
  }
}
