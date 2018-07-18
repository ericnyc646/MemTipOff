import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { QuicksheetsioService } from '../datalayer/quicksheetsio.service';
// import { AuthordashboardComponent } from './authordashboard/authordashboard.component';
// import { AuthormyquicksheetsComponent } from './authormyquicksheets/authormyquicksheets.component';
// import { AuthorsettingsComponent } from './authorsettings/authorsettings.component';

@NgModule({
  imports: [
    CommonModule
  ],
  providers: [QuicksheetsioService],
  declarations: [
    // AuthordashboardComponent, AuthormyquicksheetsComponent, AuthorsettingsComponent
  ]
})
export class AuthorwebmodModule { }
