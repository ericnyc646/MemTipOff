import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PublicsidenavComponent } from './publicsidenav.component';

describe('PublicsidenavComponent', () => {
  let component: PublicsidenavComponent;
  let fixture: ComponentFixture<PublicsidenavComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PublicsidenavComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PublicsidenavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
