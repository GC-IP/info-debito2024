import { HttpBackend, HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { Utente } from "../../models/utente";
import { Task } from "../../models/task";//???



const fakeTasks: Task[] = [{
    id: 1,
    descrizione: 'Task di Andrea',
    dataTodo: new Date('2024-07-15'),
    dataDoing:undefined,
    dataDone: undefined,
},{
    id: 2,
    descrizione: 'Task di Greta',
    dataTodo: new Date('2024-07-31'),
    dataDoing:undefined,
    dataDone: undefined,
}];

@Injectable({
    providedIn: 'root'
})
export class TasksService{
    url = 'https://localhost:44322/api/tasks';

    
    constructor(private http: HttpClient) { }

    list(): Observable<Task[]>{
        //return this.http.get<Task[]>(this.url);
        return of(fakeTasks);
    }

    listDaAssegnare(): Observable<Task[]>{
        //return this.http.get<Task[]>(this.url + '/nonAssegnati');
        return of(fakeTasks);
    }

    listAssegnati(idUtente: number): Observable<Task[]>{
        //return this.http.get<Task[]>(this.url + '/assegnati/' + idUtente);
        return of(fakeTasks);
    }

} 
