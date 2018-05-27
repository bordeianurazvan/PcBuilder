import { Routes, RouterModule } from '@angular/router';
import { ConfiguratorComponent } from './configurator.component';
import { CaseComponent } from './components/case/case.component';

const routes: Routes = [
  {
    path: '',
    component: ConfiguratorComponent,
    children: [{ path: 'case', component: CaseComponent }]
  }
];

export const ConfiguratorRoutes = RouterModule.forChild(routes);
