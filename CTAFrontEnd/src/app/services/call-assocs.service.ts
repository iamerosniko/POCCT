import { Injectable } from '@angular/core';

import { ClientApiService } from './clientapi.service'; 
import { ClientApiSettings } from './clientapi.settings'; 
import { CT_CallerAssocs } from '../entities';
@Injectable({
  providedIn: 'root'
})
export class CallAssocsService {

  constructor(private api:ClientApiService) { }
  
  getAssocs() {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallerAssocs")
    return this.api.getAll();
  }

  getAssoc(id: string) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallerAssocs")
    return this.api.getOne(id);
  }

  postAssoc(data: CT_CallerAssocs) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallerAssocs")
    var body = JSON.stringify(data);
    return this.api.postData(body);
  } 

  putAssoc(data: CT_CallerAssocs) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallerAssocs")
    var body = JSON.stringify(data);
    return this.api.putData(body);
  }

  deleteAssoc(id: string) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallerAssocs")
    return this.api.deleteData(id);
  }

}
