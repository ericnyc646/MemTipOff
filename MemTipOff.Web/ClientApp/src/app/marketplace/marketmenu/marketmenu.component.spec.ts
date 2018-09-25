import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MarketmenuComponent } from './marketmenu.component';

describe('MarketmenuComponent', () => {
  let component: MarketmenuComponent;
  let fixture: ComponentFixture<MarketmenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MarketmenuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MarketmenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
