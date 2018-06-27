import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreatequicksheetComponent } from './createquicksheet.component';

describe('CreatequicksheetComponent', () => {
  let component: CreatequicksheetComponent;
  let fixture: ComponentFixture<CreatequicksheetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreatequicksheetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreatequicksheetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
