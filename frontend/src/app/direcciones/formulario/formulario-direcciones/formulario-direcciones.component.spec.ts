import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormularioDireccionesComponent } from './formulario-direcciones.component';

describe('FormularioDireccionesComponent', () => {
  let component: FormularioDireccionesComponent;
  let fixture: ComponentFixture<FormularioDireccionesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormularioDireccionesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormularioDireccionesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
