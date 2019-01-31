import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { MaintenanceComponent } from "./maintenance.component";
import { RouterModule } from "@angular/router";
import { CallCategoriesComponent } from "./call-categories/call-categories.component";
import { CallerAssociationComponent } from "./caller-association/caller-association.component";
import { CallStatusComponent } from "./call-status/call-status.component";
import { MainTableComponent } from "./main-table/main-table.component";
import {
  CallAssocsService,
  CallCategoriesService,
  CallsService,
  CallStatusesService
} from "../services/myservices";
@NgModule({
  declarations: [
    MaintenanceComponent,
    CallCategoriesComponent,
    CallerAssociationComponent,
    CallStatusComponent,
    MainTableComponent
  ],
  imports: [CommonModule, RouterModule],
  providers: [
    CallAssocsService,
    CallCategoriesService,
    CallsService,
    CallStatusesService
  ]
})
export class MaintenanceModule {}
