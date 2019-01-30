import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallTrackerComponent } from './call-tracker.component';

describe('CallTrackerComponent', () => {
  let component: CallTrackerComponent;
  let fixture: ComponentFixture<CallTrackerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallTrackerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallTrackerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
