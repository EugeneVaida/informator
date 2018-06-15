import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TodayTimeTableComponent } from './today-time-table.component';

describe('TodayTimeTableComponent', () => {
  let component: TodayTimeTableComponent;
  let fixture: ComponentFixture<TodayTimeTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TodayTimeTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TodayTimeTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
