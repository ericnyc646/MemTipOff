import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MarketlistingsComponent } from './marketlistings.component';

describe('MarketlistingsComponent', () => {
  let component: MarketlistingsComponent;
  let fixture: ComponentFixture<MarketlistingsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MarketlistingsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MarketlistingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
