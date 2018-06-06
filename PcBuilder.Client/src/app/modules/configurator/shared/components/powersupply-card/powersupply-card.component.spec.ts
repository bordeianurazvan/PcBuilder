/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PowersupplyCardComponent } from './powersupply-card.component';

describe('PowersupplyCardComponent', () => {
  let component: PowersupplyCardComponent;
  let fixture: ComponentFixture<PowersupplyCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PowersupplyCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PowersupplyCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
