import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MarketproductdetailComponent } from './marketproductdetail.component';

describe('MarketproductdetailComponent', () => {
  let component: MarketproductdetailComponent;
  let fixture: ComponentFixture<MarketproductdetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MarketproductdetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MarketproductdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
