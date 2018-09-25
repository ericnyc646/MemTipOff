import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutsidenavComponent } from './aboutsidenav.component';

describe('AboutsidenavComponent', () => {
  let component: AboutsidenavComponent;
  let fixture: ComponentFixture<AboutsidenavComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AboutsidenavComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AboutsidenavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
