import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';

import { UserRegistration } from '../models/user.registration.interface';

import { BaseService } from './base.service';

import { Observable, of, BehaviorSubject } from 'rxjs';
import { mapChildrenIntoArray } from '../../../node_modules/@angular/router/src/url_tree';

@Injectable()
export class UserauthserviceService extends BaseService {

  baseUrl: string = '';
  
    // Observable navItem source
    authNavStatusSource = new BehaviorSubject<boolean>(false);
    // Observable navItem stream
    authNavStatus$ = this.authNavStatusSource.asObservable();
  
    private loggedIn = false;

    constructor(private http: HttpClient) {
      super();
      this.loggedIn = !!localStorage.getItem('auth_token');
      // ?? not sure if this the best way to broadcast the status but seems to resolve issue on page refresh where auth status is lost in
      // header component resulting in authed user nav links disappearing despite the fact user is still logged in
      this.authNavStatusSource.next(this.loggedIn);
    }

    register(email: string, password: string, firstName: string, lastName: string,location: string): Observable<string> {
  
      let body = JSON.stringify({ email, password, firstName, lastName,location });
      let httpHeaders = new HttpHeaders({
        'Content-Type' : 'application/json',
        'Cache-Control': 'no-cache'
        });   
  
      return this.http.post<string>("/api/Accounts", body,
         {
           headers:  httpHeaders
         });
    
      }

      
   login(email, password) {

    let body = JSON.stringify({ email, password});
    let httpHeaders = new HttpHeaders({
      'Content-Type' : 'application/json',
      'Cache-Control': 'no-cache'
      });  

    return this.http.post<string>("/api/Auth/login", body, { headers:  httpHeaders });
  }



  logout() {
    localStorage.removeItem('auth_token');
    this.loggedIn = false;
    this.authNavStatusSource.next(false);
  }

  isLoggedIn() {
    return this.loggedIn;
  }

  facebookLogin(accessToken:string) {
    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let body = JSON.stringify({ accessToken });  
    // return this.http
    //   .post(
    //   this.baseUrl + '/externalauth/facebook', body, { headers })
    //   .map(res => res.json())
    //   .map(res => {
    //     localStorage.setItem('auth_token', res.auth_token);
    //     this.loggedIn = true;
    //     this._authNavStatusSource.next(true);
    //     return true;
    //   })
    //   .catch(this.handleError);
  }


}
