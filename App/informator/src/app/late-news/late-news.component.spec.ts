import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LateNewsComponent } from './late-news.component';

describe('LateNewsComponent', () => {
  let component: LateNewsComponent;
  let fixture: ComponentFixture<LateNewsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LateNewsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LateNewsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
