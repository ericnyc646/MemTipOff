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
// Author Module
import { AuthorwebmodModule } from './authorwebmod/authorwebmod.module';
import { CreatequicksheetComponent } from './authorwebmod/createquicksheet/createquicksheet.component';
import { AuthordashboardComponent } from './authorwebmod/authordashboard/authordashboard.component';
import { AuthormyquicksheetsComponent } from './authorwebmod/authormyquicksheets/authormyquicksheets.component';
import { AuthorsettingsComponent } from './authorwebmod/authorsettings/authorsettings.component';


const appRoutes: Routes = [
  { path: '', component: HomepageComponent },
  { path: 'createquicksheet', component: CreatequicksheetComponent },
  { path: 'authorsdashboard', component: AuthordashboardComponent }
];


@NgModule({
  declarations: [
    AppComponent,
    DatalayerComponent,
    CreatequicksheetComponent,
    AuthordashboardComponent,
    AuthormyquicksheetsComponent,
    AuthorsettingsComponent
  ],
  imports: [
    BrowserModule,
    AuthorwebmodModule,
    FormsModule,
    HttpClientModule,
    PublicwebmodModule,
    NgbModule.forRoot(),
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    QuicksheetsioService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
