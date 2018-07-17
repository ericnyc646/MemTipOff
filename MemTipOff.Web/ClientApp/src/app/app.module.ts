import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
// General
import { DatalayerComponent } from './datalayer/datalayer.component';
import { QuicksheetsioService } from './datalayer/quicksheetsio.service';
// Public Module
import { PublicwebmodModule } from './publicwebmod/publicwebmod.module';
import { HomepageComponent } from './publicwebmod/homepage/homepage.component';
// Author Module
import { AuthorwebmodModule } from './authorwebmod/authorwebmod.module';
import { CreatequicksheetComponent } from './authorwebmod/createquicksheet/createquicksheet.component';



const appRoutes: Routes = [
  { path: '', component: HomepageComponent },
  { path: 'createquicksheet', component: CreatequicksheetComponent }
];


@NgModule({
  declarations: [
    AppComponent,
    DatalayerComponent,
    CreatequicksheetComponent
  ],
  imports: [
    BrowserModule,
    AuthorwebmodModule,
    FormsModule,
    HttpClientModule,
    PublicwebmodModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    QuicksheetsioService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
