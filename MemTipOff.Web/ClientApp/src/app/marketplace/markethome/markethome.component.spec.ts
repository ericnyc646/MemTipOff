import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MarkethomeComponent } from './markethome.component';

describe('MarkethomeComponent', () => {
  let component: MarkethomeComponent;
  let fixture: ComponentFixture<MarkethomeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MarkethomeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MarkethomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
