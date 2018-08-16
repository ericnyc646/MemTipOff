import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Credentials  } from '../../models/credentials.interface';
import { UserauthserviceService } from '../../datalayer/userauthservice.service';
import { BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-signinpage',
  templateUrl: './signinpage.component.html',
  styleUrls: ['./signinpage.component.css']
})
export class SigninpageComponent implements OnInit {

  brandNew: boolean;
  errors: string;
  isRequesting: boolean;
  submitted: boolean = false;
  private loggedIn = false;
  credentials: Credentials = { email: '', password: '' };



  constructor(private router: Router, private userauthservice: UserauthserviceService) {
    this.loggedIn = !!localStorage.getItem('auth_token');
  }

  ngOnInit() {
  }

  login({value, valid}: { value: Credentials, valid: boolean }) {
    this.submitted = true;
    this.isRequesting = true;
    this.errors='';
    if (valid) {
      this.userauthservice.login(value.email, value.password)
        .subscribe(data => { this.processlogin(data) });
    }    
  }

  processlogin(data) {
    localStorage.setItem('auth_token', data.auth_token);
    this.loggedIn = true;
    this.userauthservice.authNavStatusSource.next(true);
    this.router.navigate(['/authors/create']);
  }

}
