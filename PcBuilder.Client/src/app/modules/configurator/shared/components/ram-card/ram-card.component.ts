import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-ram-card',
  templateUrl: './ram-card.component.html',
  styleUrls: ['./ram-card.component.css']
})
export class RamCardComponent implements OnInit {
  @Input() ram;
  @Output() ramEvent = new EventEmitter<number>();

  onSelect() {
    this.ram.isSelected = !this.ram.isSelected;
    this.ramEvent.emit(this.ram.id);
  }

  constructor() { }

  ngOnInit() {
  }

}
