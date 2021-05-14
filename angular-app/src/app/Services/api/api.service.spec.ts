import { inject, TestBed } from '@angular/core/testing';
import { HttpClient, HttpHandler } from '@angular/common/http';
import { ApiService } from './api.service';

describe('ApiService', () => {
  let service: ApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HttpClient,HttpHandler]
    });
    service = TestBed.inject(ApiService);
  });

  it('should be created', inject([ApiService], (service: ApiService, http: HttpClient) => {
    expect(service).toBeTruthy();
  }));
});

