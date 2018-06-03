/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';
import { CaseCardComponent } from './case-card.component';

describe('CardComponent', () => {
  let component: CaseCardComponent;
  let fixture: ComponentFixture<CaseCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CaseCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CaseCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
