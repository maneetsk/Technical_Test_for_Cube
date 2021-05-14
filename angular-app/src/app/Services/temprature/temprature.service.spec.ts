import { inject, TestBed } from '@angular/core/testing';

import { TempratureService } from './temprature.service';
import { ApiService } from '../api/api.service';
import { HttpClient, HttpHandler } from '@angular/common/http';

describe('TempratureService', () => {
  let service: TempratureService;

  beforeEach(() => {
    TestBed.configureTestingModule({ providers: [ApiService, HttpClient, HttpHandler] });
    service = TestBed.inject(TempratureService);
  });


  it('should be created', inject([TempratureService], (service: TempratureService, apiService: ApiService) => {
    expect(service).toBeTruthy();
  }));
});
