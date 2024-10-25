
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

// Importar los componentes de Clientes
import { ListaClientesComponent } from './clientes/lista/lista-clientes/lista-clientes.component';

// Importar los componentes de Direcciones
import { ListaDireccionesComponent } from './direcciones/lista/lista-direcciones/lista-direcciones.component';
import { FormularioClientesComponent } from './clientes/formulario/formulario-clientes/formulario-clientes.component';

const routes: Routes = [
  { path: '', redirectTo: '/clientes', pathMatch: 'full' },
  
  // Rutas de Clientes
  { path: 'clientes', component: ListaClientesComponent },
  { path: 'clientes/nuevo', component: FormularioClientesComponent },
  { path: 'clientes/editar/:id', component: FormularioClientesComponent },
  
  // Rutas de Direcciones
  { path: 'direcciones', component: ListaDireccionesComponent },
  { path: 'direcciones/nuevo', component: FormularioClientesComponent },
  { path: 'direcciones/editar/:id', component: FormularioClientesComponent },
  
  { path: '**', redirectTo: '/clientes' } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
