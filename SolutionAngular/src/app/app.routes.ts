import { NgModule } from "@angular/core";
import { Routes, RouterModule, Router } from '@angular/router';
import { HomeComponent } from "./components/home/home.component";
import { GoogleMapComponent } from "./pages/google-map/google-map.component";
import { GoogleMapCaptureComponent } from "./pages/google-map-capture/google-map-capture.component";
import { GoogleMapViewComponent } from './pages/google-map-view/google-map-view.component';

const routes: Routes = [
  { path: 'home',component: HomeComponent },
  { path: 'mapa',component: GoogleMapComponent },
  { path: 'mapaCampturar',component: GoogleMapCaptureComponent },
  { path: 'mapaView',component: GoogleMapViewComponent },
  { path:'**',pathMatch:'full',redirectTo:'home'}
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
