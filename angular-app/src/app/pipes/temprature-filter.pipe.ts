import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
	name: 'tempraturefilter',
	pure: false
})
export class TempratureFilterPipe implements PipeTransform {

	transform(value: any[], args?: any): any[] {
		if (args != undefined && args != null && args != '') {
			return value.filter(data => data != args.value);
		}
		return value;
	}

}
