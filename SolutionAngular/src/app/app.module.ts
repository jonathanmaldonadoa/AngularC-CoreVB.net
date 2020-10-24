import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AgmCoreModule } from '@agm/core';



import { AppRoutingModule } from "./app.routes";
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from '@angular/common/http';
//rutas
//servicios

//componentes
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { HomeComponent } from './components/home/home.component';
import { GoogleMapComponent } from './pages/google-map/google-map.component';
import { GoogleMapCaptureComponent } from './pages/google-map-capture/google-map-capture.component';
import { GoogleMapViewComponent } from './pages/google-map-view/google-map-view.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    GoogleMapComponent,
    GoogleMapCaptureComponent,
    GoogleMapViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    AgmCoreModule.forRoot({
      
      apiKey: ''
    })

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
      



