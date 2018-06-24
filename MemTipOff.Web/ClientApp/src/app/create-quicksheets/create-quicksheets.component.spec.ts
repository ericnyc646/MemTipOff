import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateQuicksheetsComponent } from './create-quicksheets.component';

describe('CreateQuicksheetsComponent', () => {
  let component: CreateQuicksheetsComponent;
  let fixture: ComponentFixture<CreateQuicksheetsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateQuicksheetsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateQuicksheetsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
