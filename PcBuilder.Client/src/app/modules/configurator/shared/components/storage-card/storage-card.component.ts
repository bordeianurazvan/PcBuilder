import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';

@Component({
  selector: 'app-storage-card',
  templateUrl: './storage-card.component.html',
  styleUrls: ['./storage-card.component.css']
})
export class StorageCardComponent implements OnInit {
  @Input() storage;
  @Output() storageEvent = new EventEmitter<number>();

  onSelect() {
    this.storage.isSelected = !this.storage.isSelected;
    this.storageEvent.emit(this.storage.id);
  }
  constructor() { }

  ngOnInit() {
  }

}
