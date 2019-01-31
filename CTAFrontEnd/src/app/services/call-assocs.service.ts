import { Injectable } from '@angular/core';

import { ClientApiService } from './clientapi.service'; 
import { ClientApiSettings } from './clientapi.settings'; 
@Injectable({
  providedIn: 'root'
})
export class CallAssocsService {

  constructor(private api:ClientApiService) { }

 
}
