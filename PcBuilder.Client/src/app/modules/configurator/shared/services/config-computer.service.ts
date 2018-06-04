import { Injectable } from '@angular/core';
import { Computer } from '../models/Computer';

@Injectable()
export class ConfigComputerService {
  public computer: Computer;
  public price: number;

  constructor() {
    this.computer = new Computer();
    this.price = 0;
  }

}
