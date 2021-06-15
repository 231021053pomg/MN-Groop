import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-kategori',
  templateUrl: './kategori.component.html',
  styleUrls: ['./kategori.component.css']
})
export class KategoriComponent implements OnInit {

  KategoriProduct: string = "Bolcher";
  KategoriProduct2: string = "vingummier";
  constructor() { }

  ngOnInit(): void {
  }

}
