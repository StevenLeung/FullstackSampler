import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { DemoAppComponent } from './demo-app/demo-app.component';

export const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'demo', component: DemoAppComponent },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];