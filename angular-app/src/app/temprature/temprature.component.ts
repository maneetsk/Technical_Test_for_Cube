

import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup } from '@angular/forms';
import { ValidationService } from '../Services/validate/validation.service';
import { TempratureService } from '../Services/temprature/temprature.service';
import { ToastrService } from 'ngx-toastr';
import { TempratureResponse } from '../Models/TempratureResponse';

@Component({
	selector: 'app-temprature',
	templateUrl: './temprature.component.html',
	styleUrls: ['./temprature.component.css'],
})


export class TempratureComponent implements OnInit {
	public TempratureForm: FormGroup;
	ShowConvertedTemprature: boolean = false;
	public tempratureResponse: TempratureResponse;

	public TempratureOptions: string[] = ['Kelvin', 'Celsius', 'Fahrenheit'];

	constructor(private formBuilder: FormBuilder, private tempratureService: TempratureService, private toastrService: ToastrService) {
	}

	ngOnInit() {
		this.createForm();
	}

	// Submit form
	doRegister() {
		this.ShowConvertedTemprature = false;
		this.tempratureService.ConvertUnit(this.TempratureForm.controls.convert_from.value, this.TempratureForm.controls.convert_to.value, this.TempratureForm.controls.current_temprature.value)
			.subscribe(resp => {
				if (resp.message = 'Success') {
					this.tempratureResponse = resp.temprature;
					this.ShowConvertedTemprature = true;
				} else {
					this.toastrService.error(resp.message);
				}
			},
				err => {
					this.toastrService.error(err.message, 'Error in API call');
				})


	}

	createForm() {

		this.TempratureForm = this.formBuilder.group({
			current_temprature: ['', [Validators.required]],
			convert_from: [null, [Validators.required]],
			convert_to: [null, [Validators.required]]

		},
			{
				validators: [ValidationService.checkConversionUnits()],
				updateOn: 'change',
			});
	}
}