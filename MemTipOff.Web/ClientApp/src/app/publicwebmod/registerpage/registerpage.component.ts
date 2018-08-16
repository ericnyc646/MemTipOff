import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { UserRegistration  } from '../../models/user.registration.interface';

import { UserauthserviceService } from '../../datalayer/userauthservice.service';


@Component({
  selector: 'app-registerpage',
  templateUrl: './registerpage.component.html',
  styleUrls: ['./registerpage.component.css']
})
export class RegisterpageComponent implements OnInit {

  errors: string;  
  isRequesting: boolean;
  submitted: boolean = false;
  thedata: string;

  constructor(private router: Router, private userauthservice: UserauthserviceService) { }

  ngOnInit() {
  }

  registerUser({ value, valid }: { value: UserRegistration, valid: boolean }) {
    this.submitted = true;
    this.isRequesting = true;
    this.errors='';
    if(valid)
    {
      this.userauthservice.register(value.email, value.password, value.firstName, value.lastName,value.location)
        .subscribe(data => this.thedata = data);

    }      
 } 

}
