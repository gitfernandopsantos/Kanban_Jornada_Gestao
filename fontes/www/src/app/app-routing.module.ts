import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { KanbanAppComponent } from '../app/pages/kanban/kanban.app.component';

const routes: Routes = [
  { path: 'inicio', component: HomeComponent },
  { path: 'kanban', component: KanbanAppComponent },
  { path: '', redirectTo: 'inicio', pathMatch: 'full' },
  { path: '**', redirectTo: 'not-found' }

];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]

})
export class AppRoutingModule { }
