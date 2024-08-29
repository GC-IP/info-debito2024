import { HttpBackend, HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { Utente } from "../../models/utente";

const fakeUtenti: Utente[] = [{
    id: 1,
    mail: 'greta@colleoni.info',
    nome: 'Greta',
    cognome: 'Colleoni',
}];
@Injectable({
    providedIn: 'root'
})
export class UtentiService{
    url = 'https://localhost:44322/api/utenti';

    
    constructor(private http: HttpClient) { }

    list(): Observable<Utente[]>{
        //return this.http.get<Utente[]>(this.url);
        return of(fakeUtenti);
    }

} 
