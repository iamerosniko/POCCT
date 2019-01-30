import { Injectable } from '@angular/core';

import { ClientApiService } from './clientapi.service'; 
import { ClientApiSettings } from './clientapi.settings'; 
@Injectable({
  providedIn: 'root'
})
export class BtamserviceService {

  constructor(private api:ClientApiService) {
    api.normalHeader();
  }

  logIn(){
    
    this.api.normalHeader();
    this.api.apiUrl="https://calltracker.apps.cac.preview.pcf.manulife.com/api/btamconnection/appsignin/alverer@mfcgd.com"
    var res= this.api.getAll();
    return res;
  }
}
