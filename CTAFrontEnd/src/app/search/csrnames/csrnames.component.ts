import {  Component, OnInit, Input, OnChanges } from '@angular/core';
import { CT_Calls, GroupCSRName } from "../../entities";

@Component({
  selector: 'csrnames',
  templateUrl: './csrnames.component.html',
  styleUrls: ['./csrnames.component.css']
})
export class CsrnamesComponent implements OnInit,OnChanges {

  constructor() { }

  @Input() calls: CT_Calls[];

  grpCSRNames: GroupCSRName[] = [];

  async ngOnInit() {
    await this.generateReport();
  }
  async ngOnChanges() {
    await this.generateReport();
  }

  async generateReport(){
    this.grpCSRNames=[];
    this.calls.forEach(call => {
      var details = this.calls.filter(
        x => x.user_name == call.user_name
      );
      var isexist = this.grpCSRNames.filter(
        x => x.CSRName == call.user_name
      ).length;
      console.log(isexist);
      if (isexist == 0) {
        if (details != null) {
          var csrNames = <GroupCSRName>{CSRName:call.user_name,CSRNameDetails:[] };
          details.forEach(d => {
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
  }

}
