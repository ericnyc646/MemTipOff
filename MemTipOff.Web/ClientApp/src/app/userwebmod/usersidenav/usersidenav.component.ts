import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserDetails } from '../../models/userdetails.interface';
import { UserauthserviceService } from '../../datalayer/userauthservice.service';

@Component({
  selector: 'app-usersidenav',
  templateUrl: './usersidenav.component.html',
  styleUrls: ['./usersidenav.component.css']
})
export class UsersidenavComponent implements OnInit {
  titlename = "";
  

  constructor(private router: Router, private userauthservice: UserauthserviceService) { }

  ngOnInit() {
    this.userauthservice.getUserDetails()
      .subscribe((userdetails: UserDetails) => {
        this.titlename = userdetails.firstName + '\'s Account';
      })
  }

}
