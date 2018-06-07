import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-cooler-card',
  templateUrl: './cooler-card.component.html',
  styleUrls: ['./cooler-card.component.css']
})
export class CoolerCardComponent implements OnInit {
  @Input() cooler;
  @Output() coolerEvent = new EventEmitter<number>();

  onSelect() {
    this.cooler.isSelected = !this.cooler.isSelected;
    this.coolerEvent.emit(this.cooler.id);
  }
  constructor() { }

  ngOnInit() {
  }

}
