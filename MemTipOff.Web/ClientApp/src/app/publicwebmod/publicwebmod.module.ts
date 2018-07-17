import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomepageComponent } from './homepage/homepage.component';
import { FaqComponent } from './faq/faq.component';
import { AboutpageComponent } from './aboutpage/aboutpage.component';
import { RegisterpageComponent } from './registerpage/registerpage.component';
import { SigninpageComponent } from './signinpage/signinpage.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [HomepageComponent, FaqComponent, AboutpageComponent, RegisterpageComponent, SigninpageComponent]
})
export class PublicwebmodModule { }
