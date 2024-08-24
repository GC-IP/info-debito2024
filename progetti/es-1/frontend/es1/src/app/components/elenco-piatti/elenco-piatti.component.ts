import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Piatto } from '../../models/piatto.';
import { FormPiattoComponent } from '../form-piatto/form-piatto.component';

@Component({
  selector: 'app-elenco-piatti',
  standalone: true,
  imports: [
    CommonModule,
    FormPiattoComponent,
  ],
  templateUrl: 'elenco-piatti.component.html',
  styleUrl: './elenco-piatti.component.css',
  changeDetection: ChangeDetectionStrategy.Default,
})
export class ElencoPiattiComponent implements OnInit {

  piatti?: Piatto[];
  showForm: boolean = false;

  constructor(
    private http: HttpClient,
  ) {

  }

  ngOnInit(): void {
    this.http.get<Piatto[]>('https://localhost:7298/api/piatti').subscribe({
      next: piatti => {
        this.piatti = piatti;
      }
    });
  }
  mostraForm() {
    this.showForm = true;
  }
}