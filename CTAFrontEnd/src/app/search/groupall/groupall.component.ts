import { Component, OnInit, Input, OnChanges } from "@angular/core";
import { CT_Calls, GroupCallerAssoc, GroupCSRName,GroupCallStatus,GroupCallCategory } from "../../entities";

@Component({
  selector: "groupall",
  templateUrl: "./groupall.component.html",
  styleUrls: ["./groupall.component.css"]
})
export class GroupallComponent implements OnInit, OnChanges {
  constructor() {}

  @Input() calls: CT_Calls[];
  grpCallerAssocs: GroupCallerAssoc[] = [];
  grpCSRNames: GroupCSRName[] = [];
  grpCallStatus: GroupCallStatus[] = [];
  grpCategories: GroupCallCategory[] = [];
  //CallerAssocDetailsTotal
  async ngOnInit() {
    await this.generateReport();
  }
  async ngOnChanges() {
    await this.generateReport();
  }

  async generateReport(){
    this.grpCallerAssocs=[];
    this.calls.forEach(call => {
      var details = this.calls.filter(
        x => x.CallerAssocID == call.CallerAssocID
      );
      console.log(details.lastIndexOf);
      var isexist = this.grpCallerAssocs.filter(
        x => x.CallerAssoc == call.CallerAssoc
      ).length;
      //console.log(isexist);
      if (isexist == 0) {
        if (details != null) {
          var callerAssoc = <GroupCallerAssoc>{ CallerAssoc: call.CallerAssoc,CallerAssocDetails:[],CallerAssocDetailsTotal:details.length};
          details.forEach(d => {
            callerAssoc.CallerAssocDetails.push({
              CSRName: d.user_name,
              CallCategory: d.CallCategory,
              CallStatus: d.CallStatus,
              CallerPhone: d.CallerPhone,
              DateOfCall: d.DateOfCall
            });
          });
          this.grpCallerAssocs.push(callerAssoc);
        }
      }
    });
    // console.log(this.calls.length);
    // console.log(this.grpCallerAssocs);

    this.grpCSRNames=[];
    this.calls.forEach(call => {
      var csrdetails = this.calls.filter(
        x => x.user_name == call.user_name
      );      
      var isexist = this.grpCSRNames.filter(
        x => x.CSRName == call.user_name
      ).length;
      // console.log(isexist);
      if (isexist == 0) {
        if (csrdetails != null) {
          var csrNames = <GroupCSRName>{CSRName:call.user_name,CSRNameDetails:[],CSRNameDetailsTotal:csrdetails.length };
          csrdetails.forEach(d => {
            csrNames.CSRNameDetails.push({
              CallerAssoc: d.CallerAssoc,
              CallCategory: d.CallCategory,
              CallStatus: d.CallStatus,
              CallerPhone: d.CallerPhone,
              DateOfCall: d.DateOfCall
            });
          });
          this.grpCSRNames.push(csrNames);
        }
      }
    });

    this.grpCallStatus=[];
    this.calls.forEach(call => {
      var calldetails = this.calls.filter(
        x => x.CallStatusID == call.CallStatusID
      );
      var isexist = this.grpCallStatus.filter(
        x => x.CallStatus == call.CallStatus
      ).length;
      // console.log(isexist);
      if (isexist == 0) {
        if (calldetails != null) {
          var callStatus = <GroupCallStatus>{CallStatus: call.CallStatus ,CallStatusDetails:[],CallStatusDetailsTotal:calldetails.length };
          calldetails.forEach(d => {
            callStatus.CallStatusDetails.push({
              CSRName: d.user_name,
              CallerAssoc: d.CallerAssoc,
              CallCategory: d.CallCategory,
              CallerPhone: d.CallerPhone,
              DateOfCall: d.DateOfCall
            });
          });
          this.grpCallStatus.push(callStatus);
        }
      }
    });

    this.grpCategories=[];
    this.calls.forEach(call => {
      var categdetails = this.calls.filter(
        x => x.CallCategoryID == call.CallCategoryID
      );
      var isexist = this.grpCategories.filter(
        x => x.CallCategory == call.CallCategory
      ).length;
      // console.log(isexist);
      if (isexist == 0) {
        if (categdetails != null) {
          var callerAssoc = <GroupCallCategory>{CallCategory: call.CallCategory ,CallCategoryDetails:[],CallCategoryDetailsTotal:categdetails.length };
          categdetails.forEach(d => {
            callerAssoc.CallCategoryDetails.push({
              CSRName: d.user_name,
              CallerAssoc: d.CallerAssoc,
              CallStatus: d.CallStatus,
              CallerPhone: d.CallerPhone,
              DateOfCall: d.DateOfCall
            });
          });
          this.grpCategories.push(callerAssoc);
        }
      }
    });

  }
}
