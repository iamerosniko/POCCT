import { Component, OnInit } from '@angular/core';
import { CallStatusesService } from '../../services/myservices';
import { CT_CallStatuses } from '../../entities';

@Component({
  selector: 'call-status',
  templateUrl: './call-status.component.html',
  styleUrls: ['./call-status.component.css']
})
export class CallStatusComponent implements OnInit {
  callStatuses:CT_CallStatuses[];
  constructor(private callStatusSvc : CallStatusesService) { }

  async ngOnInit() {
    this.callStatuses= await this.callStatusSvc.getStatuses();
  }

}
