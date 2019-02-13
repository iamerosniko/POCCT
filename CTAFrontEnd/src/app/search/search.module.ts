import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";
import { SearchComponent } from "./search.component";
import { FormsModule } from "@angular/forms";
import {
  CallAssocsService,
  CallCategoriesService,
  CallsService,
  CallStatusesService
} from "../services/myservices";
import { CallerassocsComponent } from "./callerassocs/callerassocs.component";
import { CsrnamesComponent } from './csrnames/csrnames.component';
import { CallcategoriesComponent } from './callcategories/callcategories.component';
import { CallstatusesComponent } from './callstatuses/callstatuses.component';

@NgModule({
  declarations: [SearchComponent, CallerassocsComponent, CsrnamesComponent, CallcategoriesComponent, CallstatusesComponent],
  imports: [CommonModule, RouterModule, FormsModule],
  providers: [
    CallAssocsService,
    CallCategoriesService,
    CallsService,
    CallStatusesService
  ]
})
export class SearchModule {}
