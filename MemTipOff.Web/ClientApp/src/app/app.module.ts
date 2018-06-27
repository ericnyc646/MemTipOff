import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { DatalayerComponent } from './datalayer/datalayer.component';

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
    AuthorwebmodModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
