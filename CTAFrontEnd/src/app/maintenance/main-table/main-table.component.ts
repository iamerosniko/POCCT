import { Component, OnInit } from "@angular/core";
import {
  CallsService,
  BtamserviceService,
  CallAssocsService,
  CallCategoriesService,
  CallStatusesService
} from "../../services/myservices";
import {
  CT_Calls,
  CT_CallStatuses,
  CT_CallCategories,
  CT_CallerAssocs,
  UUser
} from "../../entities";

@Component({
  selector: "main-table",
  templateUrl: "./main-table.component.html",
  styleUrls: ["./main-table.component.css"]
})
export class MainTableComponent implements OnInit {
  public CallTrackers: CT_Calls[];
  public CallStatuses: CT_CallStatuses[];
  public CallCategories: CT_CallCategories[];
  public CallAssocs: CT_CallerAssocs[];
  public BTAMUsers: UUser[];
  public TableShow: boolean=false;
  constructor(
    private callSvc: CallsService,
    private btamSvc: BtamserviceService,
    private callerAssocSvc: CallAssocsService,
    private callCategoriesSvc: CallCategoriesService,
    private callStatusSvc: CallStatusesService
  ) {}

  async ngOnInit() {
    this.TableShow=await false;
    this.CallAssocs = await this.callerAssocSvc.getAssocs();
    this.CallStatuses = await this.callStatusSvc.getStatuses();
    this.CallCategories = await this.callCategoriesSvc.getCategories();
    this.BTAMUsers = await this.btamSvc.getUsers();
    this.CallTrackers = await this.callSvc.getCalls();
    this.TableShow=await true;
  }

  async updateCallTracker(calltracker:CT_Calls){
    await this.callSvc.putCall(calltracker);
    await this.ngOnInit();
  }

  async onKey(event:KeyboardEvent,callTracker:CT_Calls){
    if(event.key.toLowerCase()=="enter"){
      await this.updateCallTracker(callTracker);
    }
  }
}
