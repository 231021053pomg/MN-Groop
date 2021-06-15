import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BolcherComponent } from './bolcher/bolcher.component';

import { HomepageComponent } from './homepage/homepage.component';

import { KategoriComponent } from './kategori/kategori.component';

@NgModule({
  declarations: [
    AppComponent,
    BolcherComponent,

    HomepageComponent

    KategoriComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
