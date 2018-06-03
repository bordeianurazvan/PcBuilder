import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-case',
  templateUrl: './case.component.html',
  styleUrls: ['./case.component.css']
})
export class CaseComponent implements OnInit {
  cases: any[] = [];
  isDisabled = true;
  selectedCaseId: number;

  caseSelected($event) {
    if (this.selectedCaseId === $event) {
      this.selectedCaseId = undefined; // nu am nici o carcasa selectata
      this.isDisabled = true; // butonul este dezactivat cand nu e selectata nici o carcasa
    } else {
      for (let i = 0; i < this.cases.length; i++) { // parcurg carcasele
        if ($event !== this.cases[i].id) {
          this.cases[i].isSelected = false; // si le deselectez
        }
      }
      this.selectedCaseId = $event; // selectez carcasa
      this.isDisabled = false; // activez butonul de next
    }

    console.log(this.selectedCaseId);
  }

  goToCPU() {
    this.router.navigate(['/configurator/cpu']);
  }

  constructor(private router: Router) {}

  ngOnInit() {
    this.cases = [
      {
        id: 1,
        title: 'DEEPCOOL TESSERACT BF BLACK',
        price: 100,
        type: 'MidTower',
        motherboards: ['ATX', 'MTX'],
        fans: '2/6',
        slots: 7,
        cpuCoolerHeight: 180,
        videoCardWidth: 200,
        isSelected: false
      },
      {
        id: 2,
        title: 'DEEPCOOL TESSERACT BF BLACK',
        price: 100,
        type: 'MidTower',
        motherboards: ['ATX', 'MTX'],
        fans: '2/6',
        slots: 7,
        cpuCoolerHeight: 180,
        videoCardWidth: 200,
        isSelected: false
      },
      {
        id: 3,
        title: 'DEEPCOOL TESSERACT BF BLACK',
        price: 100,
        type: 'MidTower',
        motherboards: ['ATX', 'MTX'],
        fans: '2/6',
        slots: 7,
        cpuCoolerHeight: 180,
        videoCardWidth: 200,
        isSelected: false
      }
    ];
  }
}
