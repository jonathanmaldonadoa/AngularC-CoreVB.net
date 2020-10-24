import { Component, OnInit } from '@angular/core';
import { GoogleMapCaptureService } from 'src/app/services/google-map-capture.service';
import { PersonaModel } from 'src/app/model/persona.model';

@Component({
  selector: 'app-google-map',
  templateUrl: './google-map.component.html',
  styleUrls: ['./google-map.component.css']
})
export class GoogleMapComponent implements OnInit {

  constructor(private ubicacionservices: GoogleMapCaptureService) { }

   _ubicaciones: PersonaModel[] = [];

  ngOnInit(): void {
    this.getLocation();
  }

  getLocation() {
    this.ubicacionservices.GetAllUbicacion().subscribe(resp => { 
      this._ubicaciones=resp });
  }
}
