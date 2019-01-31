import { Component, OnInit } from '@angular/core';
import { CallStatusesService } from '../../services/myservices';
import { CT_CallStatuses } from '../../entities';

@Component({
  selector: 'call-status',
  templateUrl: './call-status.component.html',
  styleUrls: ['./call-status.component.css']
})
export class CallStatusComponent implements OnInit {
  CanEdit:boolean=false;

  callStatuses:CT_CallStatuses[];
  callStatus:CT_CallStatuses={};
  constructor(private callStatusSvc : CallStatusesService) { }

  async ngOnInit() {
    this.callStatuses= await this.callStatusSvc.getStatuses();
    this.CanEdit=await false;
    this.callStatus=await {Active:false}
  }

  async updateStatus(status:CT_CallStatuses){
    await this.callStatusSvc.putStatus(status);
    await this.ngOnInit();
  }

  async addStatus(status:CT_CallStatuses){
    await this.callStatusSvc.postStatus(status);
    await this.ngOnInit();
  }

  async deleteStatus(status:CT_CallStatuses){
    confirm("Are you sure you want to delete "+status.CallStatusDesc+"?") ?
    await this.callStatusSvc.deleteStatus(status.CallStatusID.toString()): null;
    await this.ngOnInit();
  }
}
