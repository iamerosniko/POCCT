import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-maintenance',
  templateUrl: './maintenance.component.html',
  styleUrls: ['./maintenance.component.css']
})
export class MaintenanceComponent implements OnInit {

  menu:number=0;

  constructor() { }

  ngOnInit() {
  }

  changeHighlight(menu:number){
    this.menu=menu;
  }
}
