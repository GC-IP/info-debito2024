import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Piatto } from '../../models/piatto.';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-form-piatto',
    standalone: true,
    imports: [
        CommonModule,
        FormsModule,
    ],
    templateUrl: 'form-piatto.component.html',
    styleUrl: './form-piatto.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush,
})
export class FormPiattoComponent {
    nome?: string;
    descrizione?: string;
    calorie?: number;
    prezzo?: number;

    constructor(
        private http: HttpClient,
    ) {

    }

    salva() {
        let piatto = {
            nome: this.nome,
            descrizione: this.descrizione,
            calorie: this.calorie,
            prezzo: this.prezzo,
        } as Piatto;

        this.http.post<any>('https://localhost:7298/api/piatti', piatto).subscribe({
            next: () => {
                this.nome = undefined;
                this.descrizione = undefined;
                this.calorie = undefined;
                this.prezzo = undefined;
            }
        });
    }

}
