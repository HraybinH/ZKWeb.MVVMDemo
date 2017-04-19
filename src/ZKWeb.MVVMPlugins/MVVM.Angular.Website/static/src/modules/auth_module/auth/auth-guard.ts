﻿import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { CanActivate } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { AppConfigService } from '../../base_module/services/app-config-service';
import { AppSessionService } from '../services/app-session-service';

@Injectable()
export class AuthGuard implements CanActivate {
	constructor(
		private router: Router,
		private appConfigService: AppConfigService,
		private appSessionService: AppSessionService) { }

	canActivate(): Observable<boolean> {
		return new Observable(o => {
			setTimeout(() => {
				this.appSessionService.getSessionInfo().subscribe(
					sessionInfo => {
						// TODO: 检查用户类型和权限
						if (sessionInfo.User != null) {
							o.next(true);
						} else {
							this.router.navigate(this.appConfigService.getLoginUrl());
							o.next(false);
						}
						o.complete();
					},
					error => {
						alert(error);
						this.router.navigate(this.appConfigService.getLoginUrl());
						o.next(false);
						o.complete();
					});
			}, 3000);
		});
	}
}
