import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdvertsidebarComponent } from './advertsidebar.component';

describe('AdvertsidebarComponent', () => {
  let component: AdvertsidebarComponent;
  let fixture: ComponentFixture<AdvertsidebarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdvertsidebarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdvertsidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
