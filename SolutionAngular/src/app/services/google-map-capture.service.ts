import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { UbicacionModel } from '../model/ubicacion.model';
import { PersonaModel } from '../model/persona.model';

const authHeaders = new HttpHeaders();
authHeaders.append('Content-Type', 'application/json');
authHeaders.append('Authorization', 'Bearer ' + 'token');
authHeaders.append('Content-Length', '');
const httpOptions = {
  headers: authHeaders
};
//*/

@Injectable({
  providedIn: 'root'
})
export class GoogleMapCaptureService {
  private heroesUrl = 'http://localhost:28294/api';

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  public AddFile3(_Palabras: UbicacionModel): Observable<any> {
   // const data = { latitud: "2.4224614", longitud: "-76.60659969999999", obs: "22", id: 2, idemp: 2 };
    console.log(_Palabras);
   // const body = JSON.stringify(data);

    return this.http.post<UbicacionModel>(this.heroesUrl + '/Ubicacion', _Palabras, httpOptions)
      .pipe(
        map((resp: any) => {
          //_obj.palabraID = resp.palabraID;
          // console.error(resp);
          return resp;
        })
      )//*/
  }

  GetAllUbicacion() {
    return this.http.get(this.heroesUrl + '/Persona/')
      .pipe(
        map(this.crearArreglo)
      )
  }

  private crearArreglo(ubicacionModelObj: Object) {
    const _ubicaciones: PersonaModel[] = [];
    Object.keys(ubicacionModelObj).forEach(
      key => {
        const ubicacion: PersonaModel = ubicacionModelObj[key];
        _ubicaciones.push(ubicacion)
      }
    );
    return _ubicaciones;
  }

  getPosition(): Promise<any> {
    return new Promise((resolve, reject) => {
      navigator.geolocation.getCurrentPosition(resp => {
        resolve({ lng: "" + resp.coords.longitude, lat: "" + resp.coords.latitude });
      },
        err => {
          reject(err);
        });
    });
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      console.error('An error occurred:', error.error.message);
    } else {

      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    return throwError(
      'Something bad happened; please try again later.');
  }


}
