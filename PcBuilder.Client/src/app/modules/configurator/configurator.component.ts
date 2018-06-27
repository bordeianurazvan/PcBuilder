import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-configurator',
  templateUrl: './configurator.component.html',
  styleUrls: ['./configurator.component.css']
})
export class ConfiguratorComponent implements OnInit {
  currentRoute: Router;
  exitConfig() {
    console.log('button pressed');
      this.router.navigate(['/']);
  }
  constructor(private router: Router) {
    this.currentRoute = this.router;
  }

  ngOnInit() {}
}
