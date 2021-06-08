import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SiteLandingComponent } from './components/site-landing/site-landing.component';
import { SiteHomeRoutingModule } from './site-home-routing.module';
import { SiteIntroComponent } from './components/site-intro/site-intro.component';



@NgModule({
  declarations: [
    SiteLandingComponent,
    SiteIntroComponent
  ],
  imports: [
    CommonModule,
    SiteHomeRoutingModule
  ]
})
export class SiteHomeModule { }
