import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-case',
  templateUrl: './case.component.html',
  styleUrls: ['./case.component.css']
})
export class CaseComponent implements OnInit {

  onSubmit() {
    console.log('case submited');
  }
  constructor() { }

  ngOnInit() {
  }

}