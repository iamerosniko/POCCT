import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SearchComponent } from './search/search.component';
import { MaintenanceComponent } from './maintenance/maintenance.component';
import { CallTrackerComponent } from './call-tracker/call-tracker.component';

const routes: Routes = [
  {
    path:'Search', component:SearchComponent
  },
  {
    path:'Maintenance', component:MaintenanceComponent
  },
  {
    path:'CallTracker', component:CallTrackerComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, 
    {
      useHash:true
    })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
