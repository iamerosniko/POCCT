import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { TopNavComponent } from "./top-nav/top-nav.component";
import { FormsModule } from "@angular/forms";
import {
  BtamserviceService,
  ClientApiService,
  ClientApiSettings
} from "./services/myservices";
import { HttpModule } from "@angular/http";
import { SearchModule } from "./search/search.module";
import { MaintenanceModule } from './maintenance/maintenance.module';
import { CallTrackerModule } from './call-tracker/call-tracker.module';

@NgModule({
  declarations: [AppComponent, TopNavComponent],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpModule,
    SearchModule,MaintenanceModule,CallTrackerModule
  ],
  providers: [BtamserviceService, ClientApiService, ClientApiSettings],
  bootstrap: [AppComponent]
})
export class AppModule {}
