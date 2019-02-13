import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallstatusesComponent } from './callstatuses.component';

describe('CallstatusesComponent', () => {
  let component: CallstatusesComponent;
  let fixture: ComponentFixture<CallstatusesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallstatusesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallstatusesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
