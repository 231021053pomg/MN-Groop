import { KvugComponent } from './kvug/kvug.component';
import { HomepageComponent } from './homepage/homepage.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BolcherComponent } from './bolcher/bolcher.component';
import { KategoriComponent } from './kategori/kategori.component';

const routes: Routes = [

  {path: '' , redirectTo: '/homepage', pathMatch: 'full'},


  {path:'', redirectTo:'/karegori', pathMatch: 'full'},
  {path: 'kategori' , component:KategoriComponent},
  
  {path:'', redirectTo:'/kvug', pathMatch:'full'},
  {path: 'kvug', component:KvugComponent},

  
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
