import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewquicksheetComponent } from './viewquicksheet.component';

describe('ViewquicksheetComponent', () => {
  let component: ViewquicksheetComponent;
  let fixture: ComponentFixture<ViewquicksheetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewquicksheetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewquicksheetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
