import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TempratureComponent } from './temprature/temprature.component';
import { AuthService } from './Services/auth/auth.service';

const homeChildRoutes: Routes = [
  {
    path: '',
    component: TempratureComponent,
  }
];


const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    children :homeChildRoutes,
    canActivate: [AuthService]
  },
  {
    path: '**',
    redirectTo: ''
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
