import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

@Injectable()
export class AuthService implements CanActivate {

	constructor() { }

	canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {

		// Logic for authenticated user goes here. For now, it just returns true
		return true;

	}
}