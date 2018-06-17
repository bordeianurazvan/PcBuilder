import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ConfigComputerService } from '../../shared/services/config-computer.service';
import { Case } from '../../shared/models/case';
import { Computer } from '../../shared/models/Computer';

@Component({
  selector: 'app-case',
  templateUrl: './case.component.html',
  styleUrls: ['./case.component.css']
})
export class CaseComponent implements OnInit {
  cases: Case[] = [];
  isDisabled = true;
  selectedCaseId: string;
  currentTotalPrice: number;

  caseSelected($event) {
    if (this.selectedCaseId === $event) {
      this.selectedCaseId = undefined;
      this.isDisabled = true;
      this.currentTotalPrice = this.currentTotalPrice - this.getCaseById($event).price;
    } else {
      for (let i = 0; i < this.cases.length; i++) {
        if ($event !== this.cases[i].id) {
          if (this.cases[i].isSelected) {
            this.currentTotalPrice =
              this.currentTotalPrice - this.getCaseById(this.cases[i].id).price;
          }
          this.cases[i].isSelected = false;
        }
      }
      this.selectedCaseId = $event;
      this.isDisabled = false;
      this.currentTotalPrice = 0;
      this.currentTotalPrice = this.currentTotalPrice + this.getCaseById(this.selectedCaseId).price;
      this.configService.computer = new Computer();
      this.configService.computer.caseId = this.selectedCaseId;
    }
  }

  getCaseById(id: string) {
    if (id !== undefined) {
      return this.cases.find(c => c.id === id);
    }
  }

  goToCPU() {
    this.configService.computer.caseId = this.selectedCaseId;
    this.configService.price = this.currentTotalPrice;
    this.configService.progress = this.configService.progress + 13;
    this.router.navigate(['/configurator/cpu']);
  }

  constructor(private router: Router, private configService: ConfigComputerService) {}

  ngOnInit() {
    this.configService.cases.getAll(JSON.stringify(this.configService.computer)).subscribe(response => {
      this.cases = response;
      this.currentTotalPrice = this.configService.price;

      if (this.configService.computer.caseId !== '') {
        this.cases.find(
          c => c.id === this.getCaseById(this.configService.computer.caseId).id
        ).isSelected = true;
        this.isDisabled = false;
      }
      this.selectedCaseId = this.configService.computer.caseId;
    });
    console.log(this.configService.computer);
  }
}
