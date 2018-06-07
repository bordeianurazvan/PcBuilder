import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-powersupply-card',
  templateUrl: './powersupply-card.component.html',
  styleUrls: ['./powersupply-card.component.css']
})
export class PowersupplyCardComponent implements OnInit {
  @Input() powersupply;
  @Output() powersupplyEvent = new EventEmitter<number>();

  onSelect() {
    this.powersupply.isSelected = !this.powersupply.isSelected;
    this.powersupplyEvent.emit(this.powersupply.id);
  }
  constructor() { }

  ngOnInit() {
  }

}
