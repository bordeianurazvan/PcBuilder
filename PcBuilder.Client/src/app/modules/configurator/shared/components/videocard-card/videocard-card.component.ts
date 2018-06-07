import { Component, OnInit, Output, Input, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-videocard-card',
  templateUrl: './videocard-card.component.html',
  styleUrls: ['./videocard-card.component.css']
})
export class VideocardCardComponent implements OnInit {
  @Input() videocard;
  @Output() videocardEvent = new EventEmitter<number>();

  onSelect() {
    this.videocard.isSelected = !this.videocard.isSelected;
    this.videocardEvent.emit(this.videocard.id);
  }
  constructor() {}

  ngOnInit() {}
}
