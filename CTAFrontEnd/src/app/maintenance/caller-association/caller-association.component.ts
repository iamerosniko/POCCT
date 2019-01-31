import { Component, OnInit } from '@angular/core';
import { CallAssocsService } from '../../services/myservices';
import { CT_CallerAssocs } from '../../entities';

@Component({
  selector: 'caller-association',
  templateUrl: './caller-association.component.html',
  styleUrls: ['./caller-association.component.css']
})
export class CallerAssociationComponent implements OnInit {
  CanEdit:boolean=false;

  assocs:CT_CallerAssocs[];
  assoc:CT_CallerAssocs={};
  constructor(private callerAssocSvc : CallAssocsService) { }

  async ngOnInit() {
    this.assocs=await this.callerAssocSvc.getAssocs();
    this.CanEdit=await false;
    this.assoc=await {Active:false}
  }

  async updateAssoc(assoc:CT_CallerAssocs){
    await this.callerAssocSvc.putAssoc(assoc);
    await this.ngOnInit();
  }

  async addAssoc(assoc:CT_CallerAssocs){
    await this.callerAssocSvc.postAssoc(assoc);
    await this.ngOnInit();
  }

  async deleteAssoc(assoc:CT_CallerAssocs){
    confirm("Are you sure you want to delete "+assoc.CallerAssocDesc+"?") ?
    await this.callerAssocSvc.deleteAssoc(assoc.CallerAssocID.toString()): null;
    await this.ngOnInit();
  }
}
