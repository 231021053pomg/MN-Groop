import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BolcherComponent } from './bolcher/bolcher.component';

import { HomepageComponent } from './homepage/homepage.component';

import { KategoriComponent } from './kategori/kategori.component';
import { KvugComponent } from './kvug/kvug.component';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    AppComponent,
    BolcherComponent,
    HomepageComponent,
    KategoriComponent,
    KvugComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
