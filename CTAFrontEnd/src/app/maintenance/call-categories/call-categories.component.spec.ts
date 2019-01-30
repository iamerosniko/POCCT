import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallCategoriesComponent } from './call-categories.component';

describe('CallCategoriesComponent', () => {
  let component: CallCategoriesComponent;
  let fixture: ComponentFixture<CallCategoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallCategoriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallCategoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
