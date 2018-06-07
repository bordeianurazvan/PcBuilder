/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CpuCardComponent } from './cpu-card.component';

describe('CpuCardComponent', () => {
  let component: CpuCardComponent;
  let fixture: ComponentFixture<CpuCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CpuCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CpuCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
