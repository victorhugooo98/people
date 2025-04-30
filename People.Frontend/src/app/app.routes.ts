import { Routes } from '@angular/router';
import { PessoasTabelaComponent } from './components/pessoas-tabela/pessoas-tabela.component';

export const routes: Routes = [
  { path: '', component: PessoasTabelaComponent },
  { path: '**', redirectTo: '' }
];
