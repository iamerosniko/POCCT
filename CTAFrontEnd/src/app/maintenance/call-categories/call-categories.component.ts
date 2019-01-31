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
  category:CT_CallCategories={};

  CanEdit:boolean=true;
  constructor(private callCategorySvc:CallCategoriesService) { }

  async ngOnInit() {
    this.categories=await this.callCategorySvc.getCategories();
    this.CanEdit=await false;
    this.category=await {Active:false}
  }

  async updateCategory(category:CT_CallCategories){
    await this.callCategorySvc.putCategory(category);
    await this.ngOnInit();
  }

  async addCategory(category:CT_CallCategories){
    await this.callCategorySvc.postCategory(category);
    await this.ngOnInit();
  }

  async deleteCategory(category:CT_CallCategories){
    confirm("Are you sure you want to delete "+category.CallCategoryDesc+"?") ?
    await this.callCategorySvc.deleteCategory(category.CallCategoryID.toString()): null;
    await this.ngOnInit();
  }

}
