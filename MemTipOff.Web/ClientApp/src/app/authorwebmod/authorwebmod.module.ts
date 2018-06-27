import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { QuicksheetsioService } from '../datalayer/quicksheetsio.service';

@NgModule({
  imports: [
    CommonModule
  ],
  providers: [QuicksheetsioService]
})
export class AuthorwebmodModule { }
