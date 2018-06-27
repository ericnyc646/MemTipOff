import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DatalayerComponent } from './datalayer.component';

describe('DatalayerComponent', () => {
  let component: DatalayerComponent;
  let fixture: ComponentFixture<DatalayerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DatalayerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DatalayerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
