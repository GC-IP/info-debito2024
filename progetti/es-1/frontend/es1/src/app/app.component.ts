import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ElencoPiattiComponent } from './components/elenco-piatti/elenco-piatti.component';
import { ElencoMenuComponent } from './components/elenco-menu/elenco-menu.component';
import { FormPiattoComponent } from './components/form-piatto/form-piatto.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    // componenti utilizzati qui
    ElencoPiattiComponent,
    ElencoMenuComponent,
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'es1';
}
