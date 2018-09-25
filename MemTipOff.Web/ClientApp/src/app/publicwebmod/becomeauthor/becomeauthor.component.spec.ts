import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BecomeauthorComponent } from './becomeauthor.component';

describe('BecomeauthorComponent', () => {
  let component: BecomeauthorComponent;
  let fixture: ComponentFixture<BecomeauthorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BecomeauthorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BecomeauthorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
