import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CsrnamesComponent } from './csrnames.component';

describe('CsrnamesComponent', () => {
  let component: CsrnamesComponent;
  let fixture: ComponentFixture<CsrnamesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CsrnamesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CsrnamesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
