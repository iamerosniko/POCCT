import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallcategoriesComponent } from './callcategories.component';

describe('CallcategoriesComponent', () => {
  let component: CallcategoriesComponent;
  let fixture: ComponentFixture<CallcategoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallcategoriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallcategoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
