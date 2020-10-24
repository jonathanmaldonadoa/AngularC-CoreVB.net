import { Component, OnInit } from '@angular/core';
import { Marcador } from 'src/app/model/marcador.class';

@Component({
  selector: 'app-google-map-view',
  templateUrl: './google-map-view.component.html',
  styleUrls: ['./google-map-view.component.css']
})
export class GoogleMapViewComponent implements OnInit {

  marcadores: Marcador[] = [];

  title = 'My first AGM project';
  lat = 2.443342;
  lng = -76.608431;

  constructor() {
    const mar1 = new Marcador(2.443342, -76.608431, "obs");
    const mar2 = new Marcador(2.444342, -76.60689969999999	, "obs");
    const mar3 = new Marcador(2.4306713, -76.61970859999999	, "obs");
    this.marcadores.push(mar1);
    this.marcadores.push(mar2);
    this.marcadores.push(mar3);
  }

  ngOnInit(): void {
  }



}
