import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UbicacionModel } from 'src/app/model/ubicacion.model';
import { GoogleMapCaptureService } from 'src/app/services/google-map-capture.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-google-map-capture',
  templateUrl: './google-map-capture.component.html',
  styleUrls: ['./google-map-capture.component.css']
})
export class GoogleMapCaptureComponent implements OnInit {

  ubicacion: UbicacionModel = new UbicacionModel();

  constructor(
    private ubicacionservices: GoogleMapCaptureService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.getLocation()

  }
  add(form: NgForm) {
    this.ubicacionservices.AddFile3(this.ubicacion).subscribe(resp => { console.log(resp) });
    this.router.navigate(['/mapa']);
  }

  getLocation() {
    this.ubicacionservices.getPosition().then(pos => {
      //console.log(pos)
      this.ubicacion.latitud = pos.lat;
      this.ubicacion.longitud = pos.lng;
      //this.latitude = pos.lat;
      //  this.longitude = pos.lng;
    });
  }


}
