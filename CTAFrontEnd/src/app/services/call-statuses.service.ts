import { Injectable } from '@angular/core';

import { ClientApiService } from './clientapi.service'; 
import { ClientApiSettings } from './clientapi.settings'; 
import { CT_CallStatuses } from '../entities';
@Injectable({
  providedIn: 'root'
})
export class CallStatusesService {

  constructor(private api:ClientApiService) { }
  getStatuses() {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallStatuses")
    return this.api.getAll();
  }

  getStatus(id: string) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallStatuses")
    return this.api.getOne(id);
  }

  postStatus(data: CT_CallStatuses) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallStatuses")
    var body = JSON.stringify(data);
    return this.api.postData(body);
  } 

  putStatus(data: CT_CallStatuses) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallStatuses")
    var body = JSON.stringify(data);
    return this.api.putData(body);
  }

  deleteStatus(id: string) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallStatuses")
    return this.api.deleteData(id);
  }
}
