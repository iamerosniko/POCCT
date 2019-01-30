import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallerAssociationComponent } from './caller-association.component';

describe('CallerAssociationComponent', () => {
  let component: CallerAssociationComponent;
  let fixture: ComponentFixture<CallerAssociationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallerAssociationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallerAssociationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
