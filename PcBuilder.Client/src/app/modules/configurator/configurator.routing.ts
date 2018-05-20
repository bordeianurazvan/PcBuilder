import { Routes, RouterModule } from '@angular/router';
import { ConfiguratorComponent } from './configurator.component';

const routes: Routes = [{ path: '', component: ConfiguratorComponent }];

export const ConfiguratorRoutes = RouterModule.forChild(routes);
