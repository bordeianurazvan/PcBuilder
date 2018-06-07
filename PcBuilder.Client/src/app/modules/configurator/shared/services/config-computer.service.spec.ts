/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ConfigComputerService } from './config-computer.service';

describe('Service: ConfigComputer', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ConfigComputerService]
    });
  });

  it('should ...', inject([ConfigComputerService], (service: ConfigComputerService) => {
    expect(service).toBeTruthy();
  }));
});
