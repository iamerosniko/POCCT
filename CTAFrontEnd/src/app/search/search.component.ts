import { Component, OnInit, ViewEncapsulation, Input } from "@angular/core";
import { CallsService } from "../services/myservices";
import { CT_Calls } from "../entities";

@Component({
  selector: "app-search",
  templateUrl: "./search.component.html",
  styleUrls: ["./search.component.css"],
  encapsulation: ViewEncapsulation.None
})
export class SearchComponent implements OnInit {
  show: boolean;
  data: any;
  groupList: any;
  searchData: any;
  groupId: Number;
  fromDate: Date;
  toDate: Date;
  message: any;

  calls: CT_Calls[] = [];
  constructor(private callsService: CallsService) {
    this.getGroupBy();
  }

  async ngOnInit() {
    this.groupList = await this.data;
    this.calls = <CT_Calls[]>await this.callsService.getCalls();
  }

  async search() {
    if (this.groupId != undefined) {
      this.calls = <CT_Calls[]>await this.callsService.getCalls();
      this.calls = this.calls.filter(
        m =>
          new Date(m.DateOfCall) >= new Date(this.fromDate) &&
          new Date(m.DateOfCall) <= new Date(this.toDate)
      );
    }
  }

  getGroupBy() {
    this.data = [
      // { Id: 1, Name: "All" },
      { Id: 2, Name: "Caller Assoc" },
      { Id: 3, Name: "CSR Name" },
      { Id: 4, Name: "Call Status" },
      { Id: 5, Name: "Call Category" }
    ];
  }

  getFromDate(event): void {
    this.fromDate = event.target.value;
  }

  getToDate(event): void {
    this.toDate = event.target.value;
  }

  changeGroup(event): void {
    this.groupId = event.target.value;
  }
}
