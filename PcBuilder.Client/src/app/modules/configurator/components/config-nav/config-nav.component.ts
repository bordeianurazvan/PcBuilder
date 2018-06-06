import { Component, OnInit } from '@angular/core';
import { ConfigComputerService } from '../../shared/services/config-computer.service';

@Component({
  selector: 'app-config-nav',
  templateUrl: './config-nav.component.html',
  styleUrls: ['./config-nav.component.css']
})
export class ConfigNavComponent implements OnInit {

  constructor(public configService: ConfigComputerService) { }

  ngOnInit() {
  }

}
