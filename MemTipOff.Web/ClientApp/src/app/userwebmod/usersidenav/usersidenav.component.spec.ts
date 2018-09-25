import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsersidenavComponent } from './usersidenav.component';

describe('UsersidenavComponent', () => {
  let component: UsersidenavComponent;
  let fixture: ComponentFixture<UsersidenavComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsersidenavComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsersidenavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
