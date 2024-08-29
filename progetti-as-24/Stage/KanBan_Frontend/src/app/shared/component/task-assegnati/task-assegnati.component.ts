import { Component, NgModule, OnInit } from '@angular/core';
import { Utente } from '../../../models/utente';
import { UtentiService } from '../../services/utenti.service';
import { TaskAssegnatiUtenteModule } from '../task-assegnati-utente/task-assegnati-utente.component';

@Component({
  selector: 'app-task-assegnati',
  templateUrl: './task-assegnati.component.html',
  styleUrl: './task-assegnati.component.css'
})
export class TaskAssegnatiComponent implements OnInit{
  listaUtenti: Utente[] = [];

  constructor(
    private utentiService: UtentiService
  ){
  }


   ngOnInit(): void {
     this.utentiService.list().subscribe(res => this.listaUtenti = res);
   }



}

@NgModule({
  imports: [ 
    TaskAssegnatiUtenteModule
   ],
   declarations: [ TaskAssegnatiComponent ],
   exports:    [ TaskAssegnatiComponent ]
})

export class TaskAssegnatiModule { }

