import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';

@Component({
  selector: 'app-case',
  templateUrl: './case.component.html',
  styleUrls: ['./case.component.css']
})
export class CaseComponent implements OnInit {
  cases: any[] = [];
  isDisabled = true;
  selectedCaseId: number;
  indexOfcaseAlreadySelected: any;

  caseSelected($event) {
    if (this.selectedCaseId === $event) {
      this.selectedCaseId = undefined;
      this.isDisabled = true;
    } else {
      for (let i = 0; i < this.cases.length; i++) {
        if ($event !== this.cases[i].id) {
          this.cases[i].isSelected = false;
        }
      }
      this.selectedCaseId = $event;
      this.isDisabled = false;
    }
  }

  goToCPU() {
    this.configService.computer.caseId = this.selectedCaseId;
    this.router.navigate(['/configurator/cpu']);
  }

  constructor(private router: Router, private configService: ConfigComputerService) {}

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
    if (this.configService.computer.caseId !== undefined) {
      this.indexOfcaseAlreadySelected = this.cases.find(
        c => c.id === this.configService.computer.caseId
      ).isSelected = true;
      if (this.indexOfcaseAlreadySelected !== undefined) {
        this.isDisabled = false;
      }
      this.selectedCaseId = this.configService.computer.caseId;
    }
  }
}
