import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

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

const appRoutes: Routes = [
    { path: '', component: HomepageComponent },
    { path: '', outlet: 'sidemenu', component: PublicsidenavComponent },
    { path: 'home', component: HomepageComponent },
    { path: 'home', outlet: 'sidemenu', component: PublicsidenavComponent },
    { path: 'about', component: AboutpageComponent},
    { path: 'about', outlet: 'sidemenu', component: AboutsidenavComponent},
    { path: 'faq', component: FaqComponent },
    { path: 'authorinfo', component: BecomeauthorComponent },
    { path: 'register', component: RegisterpageComponent },
    { path: 'signin', component: SigninpageComponent },
    { path: 'authors', component: AuthordashboardComponent },
    { path: 'authors/create', component: CreatequicksheetComponent },
    { path: 'authors/dashboard', component: AuthordashboardComponent },
    { path: 'authors/myquicksheets', component: AuthormyquicksheetsComponent },
    { path: 'authors/settings', component: AuthorsettingsComponent },
    { path: 'user', component: UserdashboardComponent },
    { path: 'user', outlet: 'sidemenu', component: UsersidenavComponent},
    { path: 'user/dashboard', component: UserdashboardComponent },
    { path: 'user/settings', component: UsersettingsComponent },
    { path: 'marketplace', component: MarkethomeComponent }
    // { path: '', component:   },
  ];

  @NgModule({
    imports: [
      // RouterModule.forRoot(appRoutes, {useHash: true})
      RouterModule.forRoot(appRoutes)
    ],
    exports: [RouterModule]
  })
  export class AppRoutingModule {
  
  }