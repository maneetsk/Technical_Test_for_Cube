import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiService } from '../api/api.service';

@Injectable({
  providedIn: 'root'
})
export class TempratureService {

  private ApiController = '/temprature'
  constructor(private apiService: ApiService) { }

  ConvertUnit(FromUnit: string, ToUnit: string, Value: number): Observable<any>{
    return this.apiService.get(`${this.ApiController}/${FromUnit}/${ToUnit}?CurrentTemprature=${Value}`)
    .pipe(map(data => data));
  }
}
