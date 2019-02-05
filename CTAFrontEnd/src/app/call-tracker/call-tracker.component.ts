import { Component, OnInit } from '@angular/core';
import { BtamserviceService } from '../services/btamservice.service';
import {
  CallAssocsService, CallCategoriesService, CallStatusesService, CallsService
} from "../services/myservices";
import {
  CT_CallStatuses,
  CT_CallCategories,
  CT_CallerAssocs,
  UUser,
  CT_Calls
} from "../entities";

@Component({
  selector: 'app-call-tracker',
  templateUrl: './call-tracker.component.html',
  styleUrls: ['./call-tracker.component.css']
})
export class CallTrackerComponent implements OnInit {
  public CallStatuses: CT_CallStatuses[];
  public CallCategories: CT_CallCategories[];
  public CallAssocs: CT_CallerAssocs[];
  public Calls:CT_Calls[];
  public Call:CT_Calls={CallerAssocID:0,CallCategoryID:0,CallStatusID:0};
  public user:UUser;
  public username:string="";
  public CurrentDate: Date;
  constructor(
    private loginSvc : BtamserviceService,
    private callerAssocSvc: CallAssocsService,
    private callCategoriesSvc: CallCategoriesService,
    private callStatusSvc: CallStatusesService,
    private callSvc: CallsService
  ) { }

  async ngOnInit() {
    this.user=await this.loginSvc.logIn();
    this.CallAssocs = await this.callerAssocSvc.getAssocs();
    this.CallStatuses = await this.callStatusSvc.getStatuses();
    this.CallCategories = await this.callCategoriesSvc.getCategories();
    this.Call = await <CT_Calls>{CallerAssocID:0,CallCategoryID:0,CallStatusID:0,user_name: this.user.UserName,DateOfCall:new Date()}
    this.CurrentDate = await new Date();
  }
  
  async save(Call:CT_Calls){
    await this.callSvc.postCall(Call);
    await this.ngOnInit();
  }

}
