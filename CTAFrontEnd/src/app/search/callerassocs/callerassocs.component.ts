import { Component, OnInit, Input, OnChanges } from "@angular/core";
import { CT_Calls, GroupCallerAssoc, CallerAssocDetails } from "../../entities";

@Component({
  selector: "callerassocs",
  templateUrl: "./callerassocs.component.html",
  styleUrls: ["./callerassocs.component.css"]
})
export class CallerassocsComponent implements OnInit, OnChanges {
  constructor() {}

  @Input() calls: CT_Calls[];
  grpCallerAssocs: GroupCallerAssoc[] = [];

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
      var isexist = this.grpCallerAssocs.filter(
        x => x.CallerAssoc == call.CallerAssoc
      ).length;
      console.log(isexist);
      if (isexist == 0) {
        if (details != null) {
          var callerAssoc = <GroupCallerAssoc>{ CallerAssoc: call.CallerAssoc,CallerAssocDetails:[] };
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
    console.log(this.calls.length);
    console.log(this.grpCallerAssocs);
  }
}
