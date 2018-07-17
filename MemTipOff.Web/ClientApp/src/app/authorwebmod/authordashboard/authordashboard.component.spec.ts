import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthordashboardComponent } from './authordashboard.component';

describe('AuthordashboardComponent', () => {
  let component: AuthordashboardComponent;
  let fixture: ComponentFixture<AuthordashboardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AuthordashboardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AuthordashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
