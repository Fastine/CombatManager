import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CombatTrackerComponent } from './combat-tracker.component';

describe('CombatTrackerComponent', () => {
  let component: CombatTrackerComponent;
  let fixture: ComponentFixture<CombatTrackerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CombatTrackerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CombatTrackerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
