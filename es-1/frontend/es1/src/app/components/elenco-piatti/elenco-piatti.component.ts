import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Piatto } from '../../models/piatto.';

@Component({
  selector: 'app-elenco-piatti',
  standalone: true,
  imports: [
    CommonModule,
  ],
  templateUrl: 'elenco-piatti.component.html',
  styleUrl: './elenco-piatti.component.css',
  changeDetection: ChangeDetectionStrategy.Default,
})
export class ElencoPiattiComponent implements OnInit {

  piatti?: Piatto[];

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
}