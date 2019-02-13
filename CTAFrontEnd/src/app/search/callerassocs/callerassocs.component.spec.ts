import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallerassocsComponent } from './callerassocs.component';

describe('CallerassocsComponent', () => {
  let component: CallerassocsComponent;
  let fixture: ComponentFixture<CallerassocsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallerassocsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallerassocsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
