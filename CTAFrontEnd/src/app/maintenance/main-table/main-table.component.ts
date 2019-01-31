import { Component, OnInit } from '@angular/core';
import { CallsService } from '../../services/myservices';
import { CT_Calls } from '../../entities';

@Component({
  selector: 'main-table',
  templateUrl: './main-table.component.html',
  styleUrls: ['./main-table.component.css']
})
export class MainTableComponent implements OnInit {
  public CallTrackers:CT_Calls[];

  constructor(private callSvc:CallsService) { }

  async ngOnInit() {
    this.CallTrackers = await this.callSvc.getCalls();
  }

}
