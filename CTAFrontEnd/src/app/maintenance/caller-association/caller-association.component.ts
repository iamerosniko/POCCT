import { Component, OnInit } from '@angular/core';
import { CallAssocsService } from '../../services/myservices';
import { CT_CallerAssocs } from '../../entities';

@Component({
  selector: 'caller-association',
  templateUrl: './caller-association.component.html',
  styleUrls: ['./caller-association.component.css']
})
export class CallerAssociationComponent implements OnInit {

  assocs:CT_CallerAssocs[];
  constructor(private callerAssocSvc : CallAssocsService) { }

  async ngOnInit() {
    this.assocs=await this.callerAssocSvc.getAssocs();
  }

}
