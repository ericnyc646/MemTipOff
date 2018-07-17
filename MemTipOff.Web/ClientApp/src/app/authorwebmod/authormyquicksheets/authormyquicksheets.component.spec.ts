import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthormyquicksheetsComponent } from './authormyquicksheets.component';

describe('AuthormyquicksheetsComponent', () => {
  let component: AuthormyquicksheetsComponent;
  let fixture: ComponentFixture<AuthormyquicksheetsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AuthormyquicksheetsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AuthormyquicksheetsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
