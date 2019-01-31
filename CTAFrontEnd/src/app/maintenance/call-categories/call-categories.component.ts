import { Component, OnInit } from '@angular/core';
import { CallCategoriesService } from '../../services/myservices';
import { CT_CallCategories } from '../../entities';

@Component({
  selector: 'call-categories',
  templateUrl: './call-categories.component.html',
  styleUrls: ['./call-categories.component.css']
})
export class CallCategoriesComponent implements OnInit {
  categories:CT_CallCategories[];
  constructor(private callCategorySvc:CallCategoriesService) { }

  async ngOnInit() {
    this.categories=await this.callCategorySvc.getCategories();
  }

}
