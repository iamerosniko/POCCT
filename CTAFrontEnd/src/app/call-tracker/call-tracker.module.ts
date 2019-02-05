import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from "@angular/forms";
import { CallTrackerComponent } from './call-tracker.component';
import { RouterModule } from "@angular/router";
import {
  BtamserviceService,
  CallAssocsService,
  CallCategoriesService,
  CallStatusesService
} from "../services/myservices";

@NgModule({
  declarations: [CallTrackerComponent],
  imports: [CommonModule, RouterModule,FormsModule],
  providers: [
    BtamserviceService,
    CallAssocsService,
    CallCategoriesService,
    CallStatusesService
  ]
})
export class CallTrackerModule { }

  

