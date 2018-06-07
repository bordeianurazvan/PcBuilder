import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-motherboard-card',
  templateUrl: './motherboard-card.component.html',
  styleUrls: ['./motherboard-card.component.css']
})
export class MotherboardCardComponent implements OnInit {
  @Input() motherboard;
  @Output() motherboardEvent = new EventEmitter<number>();

  onSelect() {
    this.motherboard.isSelected = !this.motherboard.isSelected;
    this.motherboardEvent.emit(this.motherboard.id);
  }
  constructor() { }

  ngOnInit() {
  }

}
