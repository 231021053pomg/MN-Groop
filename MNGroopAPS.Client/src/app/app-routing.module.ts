import { HomepageComponent } from './homepage/homepage.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BolcherComponent } from './bolcher/bolcher.component';
import { KategoriComponent } from './kategori/kategori.component';

const routes: Routes = [

  {path: '' , redirectTo: '/kategori', pathMatch: 'full'},
  {path: 'kategori' , component:KategoriComponent},

  {path: '' , redirectTo: '/bolcher', pathMatch: 'full'},
  {path: 'bolcher' , component: BolcherComponent},
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
