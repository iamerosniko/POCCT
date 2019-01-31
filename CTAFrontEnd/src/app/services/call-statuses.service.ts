import { Injectable } from '@angular/core';

import { ClientApiService } from './clientapi.service'; 
import { ClientApiSettings } from './clientapi.settings'; 
@Injectable({
  providedIn: 'root'
})
export class CallStatusesService {

  constructor(private api:ClientApiService) { }
}
