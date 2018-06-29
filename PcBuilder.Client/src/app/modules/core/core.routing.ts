import { Routes, RouterModule } from '@angular/router';
import { TutorialComponent } from './components/tutorial/tutorial.component';
import { CommunityComponent } from './components/community/community.component';
import { CommunityResultComponent } from './components/community-result/community-result.component';

const routes: Routes = [
  { path: 'tutorial', component: TutorialComponent },
  { path: 'community', component: CommunityComponent },
  { path: 'community/:id', component: CommunityResultComponent}
];

export const CoreRoutes = RouterModule.forChild(routes);
