import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';

import { DatalayerComponent } from './datalayer/datalayer.component';
import { QuicksheetsioService } from './datalayer/quicksheetsio.service';

import { AuthorwebmodModule } from './authorwebmod/authorwebmod.module';
import { CreatequicksheetComponent } from './authorwebmod/createquicksheet/createquicksheet.component';

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
    HttpClientModule
  ],
  providers: [
    QuicksheetsioService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
