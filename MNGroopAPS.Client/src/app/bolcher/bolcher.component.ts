import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bolcher',
  templateUrl: './bolcher.component.html',
  styleUrls: ['./bolcher.component.css']
})
export class BolcherComponent implements OnInit {

  Bolcher1: string = "Stærke";
  Bolcher2: string = "Sure";
  Bolcher3: string = "Søde";

  constructor() { }

  ngOnInit(): void {
  }

}
