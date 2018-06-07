/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { MotherboardComponent } from './motherboard.component';

describe('MotherboardComponent', () => {
  let component: MotherboardComponent;
  let fixture: ComponentFixture<MotherboardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MotherboardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MotherboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
