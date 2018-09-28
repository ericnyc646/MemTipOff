import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';

import {NgbModule} from '@ng-bootstrap/ng-bootstrap';

import { AppRoutingModule } from './app-routing.module';

// General
import { DatalayerComponent } from './datalayer/datalayer.component';
import { QuicksheetsioService } from './datalayer/quicksheetsio.service';
import { UserauthserviceService } from './datalayer/userauthservice.service';
import { FaqService  } from './datalayer/faq.service';
import { PageParametersService } from './datalayer/pageparameters.service';

// Public Module
import { PublicwebmodModule } from './publicwebmod/publicwebmod.module';
import { HomepageComponent } from './publicwebmod/homepage/homepage.component';
import { AboutpageComponent } from './publicwebmod/aboutpage/aboutpage.component';
import { FaqComponent } from './publicwebmod/faq/faq.component';
import { RegisterpageComponent } from './publicwebmod/registerpage/registerpage.component';
import { SigninpageComponent } from './publicwebmod/signinpage/signinpage.component';
import { SiteheaderComponent } from './publicwebmod/siteheader/siteheader.component';
import { SitefooterComponent } from './publicwebmod/sitefooter/sitefooter.component';
import { NavigationComponent } from './publicwebmod/navigation/navigation.component';
import { AdvertsidebarComponent } from './publicwebmod/advertsidebar/advertsidebar.component';
import { PublicsidenavComponent } from './publicwebmod/publicsidenav/publicsidenav.component';
import { AboutsidenavComponent } from './publicwebmod/aboutsidenav/aboutsidenav.component';
import { BecomeauthorComponent } from './publicwebmod/becomeauthor/becomeauthor.component';

// Author Module
import { AuthorwebmodModule } from './authorwebmod/authorwebmod.module';
import { CreatequicksheetComponent } from './authorwebmod/createquicksheet/createquicksheet.component';
import { AuthordashboardComponent } from './authorwebmod/authordashboard/authordashboard.component';
import { AuthormyquicksheetsComponent } from './authorwebmod/authormyquicksheets/authormyquicksheets.component';
import { AuthorsettingsComponent } from './authorwebmod/authorsettings/authorsettings.component';

// Marketplace Module
import { MarketplaceModule } from './marketplace/marketplace.module';
import { MarkethomeComponent } from './marketplace/markethome/markethome.component';
import { MarketlistingsComponent } from './marketplace/marketlistings/marketlistings.component';
import { MarketmenuComponent } from './marketplace/marketmenu/marketmenu.component';
import { MarketproductdetailComponent } from './marketplace/marketproductdetail/marketproductdetail.component';

// Admin Module


// User Module
import { UserwebmodModule } from './userwebmod/userwebmod.module';
import { UserdashboardComponent } from './userwebmod/userdashboard/userdashboard.component';
import { UsersettingsComponent } from './userwebmod/usersettings/usersettings.component';
import { UsersidenavComponent } from './userwebmod/usersidenav/usersidenav.component';
import { ViewquicksheetComponent } from './userwebmod/viewquicksheet/viewquicksheet.component';


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
    SiteheaderComponent,
    SitefooterComponent,
    NavigationComponent,
    AdvertsidebarComponent,
    MarkethomeComponent,
    MarketlistingsComponent,
    MarketmenuComponent,
    MarketproductdetailComponent,
    PublicsidenavComponent,
    AboutsidenavComponent,
    BecomeauthorComponent,
    UsersettingsComponent,
    UsersidenavComponent,
    ViewquicksheetComponent
  ],
  imports: [
    BrowserModule,
    AuthorwebmodModule,
    FormsModule,
    HttpClientModule,
    PublicwebmodModule,
    UserwebmodModule,
    MarketplaceModule,
    NgbModule.forRoot(),
    AppRoutingModule
    // RouterModule.forRoot(appRoutes)
  ],
  providers: [
    QuicksheetsioService,
    UserauthserviceService,
    FaqService,
    PageParametersService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
