import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MyquicksheetsComponent } from './myquicksheets.component';

describe('MyquicksheetsComponent', () => {
  let component: MyquicksheetsComponent;
  let fixture: ComponentFixture<MyquicksheetsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MyquicksheetsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MyquicksheetsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
