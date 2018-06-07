/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { RamCardComponent } from './ram-card.component';

describe('RamCardComponent', () => {
  let component: RamCardComponent;
  let fixture: ComponentFixture<RamCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RamCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RamCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
