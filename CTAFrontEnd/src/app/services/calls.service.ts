import { Injectable } from '@angular/core';

import { ClientApiService } from './clientapi.service'; 
import { ClientApiSettings } from './clientapi.settings'; 
import { CT_Calls } from '../entities';
@Injectable({
  providedIn: 'root'
})
export class CallsService {

  constructor(private api:ClientApiService) { }
  getCalls() {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("Calls")
    return this.api.getAll();
  }

  getCall(id: string) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("Calls")
    return this.api.getOne(id);
  }

  postCall(data: CT_Calls) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("Calls")
    var body = JSON.stringify(data);
    return this.api.postData(body);
  } 

  putCall(data: CT_Calls) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("Calls")
    var body = JSON.stringify(data);
    return this.api.putData(body);
  }

  deleteCall(id: string) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("Calls")
    return this.api.deleteData(id);
  }
}
