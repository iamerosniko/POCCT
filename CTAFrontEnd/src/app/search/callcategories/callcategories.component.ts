import { Component, OnInit, Input, OnChanges } from "@angular/core";
import { CT_Calls, GroupCallCategory,  } from "../../entities";

@Component({
  selector: 'callcategories',
  templateUrl: './callcategories.component.html',
  styleUrls: ['./callcategories.component.css']
})
export class CallcategoriesComponent implements OnInit,OnChanges {

  constructor() { }
  @Input() calls: CT_Calls[];
  grpCategories: GroupCallCategory[] = [];

  async ngOnInit() {
    await this.generateReport();
  }
  async ngOnChanges() {
    await this.generateReport();
  }

  async generateReport(){
    this.grpCategories=[];
    this.calls.forEach(call => {
      var details = this.calls.filter(
        x => x.CallCategoryID == call.CallCategoryID
      );
      var isexist = this.grpCategories.filter(
        x => x.CallCategory == call.CallCategory
      ).length;
      console.log(isexist);
      if (isexist == 0) {
        if (details != null) {
          var callerAssoc = <GroupCallCategory>{CallCategory: call.CallCategory ,CallCategoryDetails:[] };
          details.forEach(d => {
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
    console.log(this.calls.length);
    console.log(this.grpCategories);
  }

}
