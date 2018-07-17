import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthorsettingsComponent } from './authorsettings.component';

describe('AuthorsettingsComponent', () => {
  let component: AuthorsettingsComponent;
  let fixture: ComponentFixture<AuthorsettingsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AuthorsettingsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AuthorsettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
