

import { AfterViewInit, Directive, ElementRef, Input } from '@angular/core';

@Directive({
	selector: '[appFontSize]'
})
export class FontSizeDirective implements AfterViewInit {

	@Input() fontsize: string;

	constructor(private el: ElementRef) {
	}

	ngAfterViewInit(): void {
		this.el.nativeElement.style.fontSize = this.fontsize;
	}
}

