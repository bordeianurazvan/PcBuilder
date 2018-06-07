/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { StorageCardComponent } from './storage-card.component';

describe('StorageCardComponent', () => {
  let component: StorageCardComponent;
  let fixture: ComponentFixture<StorageCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StorageCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StorageCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
