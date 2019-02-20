import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupallComponent } from './groupall.component';

describe('GroupallComponent', () => {
  let component: GroupallComponent;
  let fixture: ComponentFixture<GroupallComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GroupallComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
