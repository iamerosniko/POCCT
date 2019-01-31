import { Injectable } from '@angular/core';

import { ClientApiService } from './clientapi.service'; 
import { ClientApiSettings } from './clientapi.settings'; 
import { CT_CallCategories } from '../entities';
@Injectable({
  providedIn: 'root'
})
export class CallCategoriesService {

  constructor(private api:ClientApiService) { }
  getCategories() {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallCategories")
    return this.api.getAll();
  }

  getCategory(id: string) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallCategories")
    return this.api.getOne(id);
  }

  postCategory(data: CT_CallCategories) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallCategories")
    var body = JSON.stringify(data);
    return this.api.postData(body);
  } 

  putCategory(data: CT_CallCategories) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallCategories")
    var body = JSON.stringify(data);
    return this.api.putData(body);
  }

  deleteCategory(id: string) {
    this.api.normalHeader();
    this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("CallCategories")
    return this.api.deleteData(id);
  }
}
