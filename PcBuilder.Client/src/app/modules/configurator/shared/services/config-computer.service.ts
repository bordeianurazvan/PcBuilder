import { Injectable } from '@angular/core';
import { Computer } from '../models/Computer';

@Injectable()
export class ConfigComputerService {
    public computer: Computer;

constructor() {
    this.computer = new Computer();
 }

}
