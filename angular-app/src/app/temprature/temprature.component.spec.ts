

import { HttpClient, HttpHandler } from '@angular/common/http';
import { ComponentFixture, inject, TestBed } from '@angular/core/testing';
import { FormBuilder } from '@angular/forms';
import { ToastrModule, ToastrService } from 'ngx-toastr';
import { TempratureService } from '../Services/temprature/temprature.service';
import { TempratureFilterPipe } from '../pipes/temprature-filter.pipe';

import { TempratureComponent } from './temprature.component';

describe('TempratureComponent', () => {
  let component: TempratureComponent;
  let fixture: ComponentFixture<TempratureComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [ToastrModule.forRoot()],
      declarations: [TempratureComponent, TempratureFilterPipe],
      providers: [FormBuilder, TempratureService, ToastrService, HttpClient, HttpHandler]
    })
      .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TempratureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

});
