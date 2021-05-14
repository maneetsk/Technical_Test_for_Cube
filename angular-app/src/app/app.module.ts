import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

//components
import { HomeComponent } from './home/home.component';
import { TempratureComponent } from './temprature/temprature.component';

//services
import { AuthService } from './Services/auth/auth.service';
import { ValidationService } from './Services/validate/validation.service';
import { ApiService } from './Services/api/api.service';
import { TempratureService } from './Services/temprature/temprature.service';

//pipes
import { TempratureFilterPipe } from './pipes/temprature-filter.pipe';

//directives
import { FontSizeDirective } from './directives/font-size.directive';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TempratureComponent,
    TempratureFilterPipe,
    FontSizeDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      timeOut: 8000,
      positionClass: 'toast-top-right',
      preventDuplicates: true,
    }),
  ],
  providers: [AuthService, ValidationService, ApiService, TempratureService],
  bootstrap: [AppComponent],
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA,
    NO_ERRORS_SCHEMA
  ]
})
export class AppModule { }
