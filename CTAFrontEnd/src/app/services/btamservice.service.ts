import { Injectable } from "@angular/core";

import { ClientApiService } from "./clientapi.service";
import { ClientApiSettings } from "./clientapi.settings";
@Injectable({
  providedIn: "root"
})
export class BtamserviceService {
  constructor(private api: ClientApiService) {
    api.normalHeader();
  }

  logIn() {
    this.api.normalHeader();
    //dev-debug mode
    // this.api.apiUrl=ClientApiSettings.GETCLIENTAPIURL("btamconnection/appsignin/alverer@mfcgd.com")
    //production - actual mode
    this.api.apiUrl = ClientApiSettings.GETCLIENTAPIURL("btamconnection/appsignin");
    var res = this.api.getAll();
    return res;
  }

  getUsers() {
    this.api.normalHeader();
    this.api.apiUrl = ClientApiSettings.GETCLIENTAPIURL(
      "btamconnection/GetUsers"
    );
    var res = this.api.getAll();
    return res;
  }
}
