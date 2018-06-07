import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-case-card',
  templateUrl: './case-card.component.html',
  styleUrls: ['./case-card.component.css']
})
export class CaseCardComponent implements OnInit {

  @Input() case;
  @Output() caseEvent = new EventEmitter<number>();

  onSelect() {
    this.case.isSelected = !this.case.isSelected;
    this.caseEvent.emit(this.case.id);
  }
  constructor() {}

  ngOnInit() {}
}
