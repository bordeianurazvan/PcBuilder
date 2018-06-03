import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {

  @Input() case;
  @Output() caseEvent = new EventEmitter<number>();

  onSelect() {
    this.case.isSelected = !this.case.isSelected;
    this.caseEvent.emit(this.case.id);
  }
  constructor() {}

  ngOnInit() {}
}
