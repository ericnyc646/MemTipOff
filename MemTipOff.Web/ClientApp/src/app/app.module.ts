import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CreateQuicksheetsComponent } from './create-quicksheets/create-quicksheets.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateQuicksheetsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
