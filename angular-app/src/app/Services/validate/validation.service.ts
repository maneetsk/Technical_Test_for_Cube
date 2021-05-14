import { Injectable } from '@angular/core';
import { ValidatorFn, AbstractControl, FormGroup } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class ValidationService {

  constructor() { }

  static checkConversionUnits(): ValidatorFn {
    return (formGroup: FormGroup) => {
      const convert_from = formGroup.get('convert_from');
      const convert_to = formGroup.get('convert_to');

      if (convert_from != undefined && convert_to != undefined && convert_from.value === convert_to.value) {
        return { checkConversionUnitsError: true };
      }
      return null;
    };
  }
}
