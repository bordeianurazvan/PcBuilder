import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-cpu-card',
  templateUrl: './cpu-card.component.html',
  styleUrls: ['./cpu-card.component.css']
})
export class CpuCardComponent implements OnInit {
  @Input() cpu;
  @Output() cpuEvent = new EventEmitter<number>();

  onSelect() {
    this.cpu.isSelected = !this.cpu.isSelected;
    this.cpuEvent.emit(this.cpu.id);
  }

  constructor() {}

  ngOnInit() {}
}
