import { Component, OnInit, Input, OnChanges } from "@angular/core";
import { CT_Calls, GroupCallStatus,  } from "../../entities";

@Component({
  selector: 'callstatuses',
  templateUrl: './callstatuses.component.html',
  styleUrls: ['./callstatuses.component.css']
})
export class CallstatusesComponent implements OnInit,OnChanges {

  constructor() { }
  @Input() calls: CT_Calls[];
  grpCallStatus: GroupCallStatus[] = [];

  async ngOnInit() {
    await this.generateReport();
  }
  async ngOnChanges() {
    await this.generateReport();
  }

  async generateReport(){
    this.grpCallStatus=[];
    this.calls.forEach(call => {
      var details = this.calls.filter(
        x => x.CallStatusID == call.CallStatusID
      );
      var isexist = this.grpCallStatus.filter(
        x => x.CallStatus == call.CallStatus
      ).length;
      console.log(isexist);
      if (isexist == 0) {
        if (details != null) {
          var callStatus = <GroupCallStatus>{CallStatus: call.CallStatus ,CallStatusDetails:[] };
          details.forEach(d => {
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
    console.log(this.calls.length);
    console.log(this.grpCallStatus);
  }

}
