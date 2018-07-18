import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';

import {NgbModule} from '@ng-bootstrap/ng-bootstrap';

// General
import { DatalayerComponent } from './datalayer/datalayer.component';
import { QuicksheetsioService } from './datalayer/quicksheetsio.service';

// Public Module
import { PublicwebmodModule } from './publicwebmod/publicwebmod.module';
import { HomepageComponent } from './publicwebmod/homepage/homepage.component';
import { AboutpageComponent } from './publicwebmod/aboutpage/aboutpage.component';
import { FaqComponent } from './publicwebmod/faq/faq.component';
import { RegisterpageComponent } from './publicwebmod/registerpage/registerpage.component';
import { SigninpageComponent } from './publicwebmod/signinpage/signinpage.component';

// Author Module
import { AuthorwebmodModule } from './authorwebmod/authorwebmod.module';
import { CreatequicksheetComponent } from './authorwebmod/createquicksheet/createquicksheet.component';
import { AuthordashboardComponent } from './authorwebmod/authordashboard/authordashboard.component';
import { AuthormyquicksheetsComponent } from './authorwebmod/authormyquicksheets/authormyquicksheets.component';
import { AuthorsettingsComponent } from './authorwebmod/authorsettings/authorsettings.component';

// Admin Module


// User Module
import { UserwebmodModule } from './userwebmod/userwebmod.module';
import { UserdashboardComponent } from './userwebmod/userdashboard/userdashboard.component';
import { MyquicksheetsComponent } from './userwebmod/myquicksheets/myquicksheets.component';


const appRoutes: Routes = [
  { path: '', component: HomepageComponent },
  { path: 'home', component: HomepageComponent },
  { path: 'about', component: AboutpageComponent },
  { path: 'faq', component: FaqComponent },
  { path: 'register', component: RegisterpageComponent },
  { path: 'signin', component: SigninpageComponent },
  { path: 'authors', component: AuthordashboardComponent },
  { path: 'authors/create', component: CreatequicksheetComponent },
  { path: 'authors/dashboard', component: AuthordashboardComponent },
  { path: 'authors/myquicksheets', component: AuthormyquicksheetsComponent },
  { path: 'authors/settings', component: AuthorsettingsComponent },
  { path: 'user', component: UserdashboardComponent },
  { path: 'user/dashboard', component: UserdashboardComponent },
  { path: 'user/myquicksheets', component: MyquicksheetsComponent }
  // { path: '', component:   },
];


@NgModule({
  declarations: [
    AppComponent,
    DatalayerComponent,
    HomepageComponent,
    CreatequicksheetComponent,
    AuthordashboardComponent,
    AuthormyquicksheetsComponent,
    AuthorsettingsComponent,
    AboutpageComponent,
    FaqComponent,
    RegisterpageComponent,
    SigninpageComponent,
    UserdashboardComponent,
    MyquicksheetsComponent
  ],
  imports: [
    BrowserModule,
    AuthorwebmodModule,
    FormsModule,
    HttpClientModule,
    PublicwebmodModule,
    UserwebmodModule,
    NgbModule.forRoot(),
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    QuicksheetsioService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
