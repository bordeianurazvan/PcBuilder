/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { VideocardCardComponent } from './videocard-card.component';

describe('VideocardCardComponent', () => {
  let component: VideocardCardComponent;
  let fixture: ComponentFixture<VideocardCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VideocardCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VideocardCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
