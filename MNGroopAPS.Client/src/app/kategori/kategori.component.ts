import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-kategori',
  templateUrl: './kategori.component.html',
  styleUrls: ['./kategori.component.css']
})
export class KategoriComponent implements OnInit {

  
  katagorier: string[] =  [];
  constructor() { }

  ngOnInit(): void {

    // this.katagorier.push("stærke vingummibamser");
    // this.katagorier.push("stræke bolsher");
  }
 

}
