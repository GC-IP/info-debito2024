import { Component, Input, NgModule, OnInit } from '@angular/core';
import { Task } from '../../../models/task';//???
import { TasksService } from '../../services/tasks.service';//???
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-task-assegnati-utente',
  templateUrl: './task-assegnati-utente.component.html',
  styleUrl: './task-assegnati-utente.component.css'
})

export class TaskAssegnatiUtenteComponent implements OnInit{
  @Input() idUtente = 0;
  @Input() stato = "DOING";
  
  listaTasksAssegnati: Task[] | undefined;
  listaTasksFiltrati: Task[] | undefined;
  constructor(
    private tasksService: TasksService
  ){

  }


   ngOnInit(): void {
    this.tasksService.listAssegnati(this.idUtente).subscribe(res => {
      this.listaTasksAssegnati = res;
      this.filtraTasks();
    });
   }

   filtraTasks(){
    if (this.stato == "TODO"){
      this.listaTasksFiltrati = this.listaTasksAssegnati?.filter(x => x.dataTodo != null && x.dataDoing == null && x.dataDone == null);
    }else if (this.stato == "DOING"){
      this.listaTasksFiltrati = this.listaTasksAssegnati?.filter(x => x.dataTodo != null && x.dataDoing != null  && x.dataDone == null);//?
    }else if (this.stato == "DONE"){
      this.listaTasksFiltrati = this.listaTasksAssegnati?.filter(x => x.dataTodo != null && x.dataDoing != null  && x.dataDone != null);//?
    }
   }
   
  passaDoing(task: Task) {
    task.dataDoing = new Date();
    }
  passaDone(task: Task) {
    task.dataDone = new Date();
    }

}

@NgModule({
  imports: [ 
    CommonModule
   ],
   declarations: [ TaskAssegnatiUtenteComponent ],
   exports:    [ TaskAssegnatiUtenteComponent ]
})

export class TaskAssegnatiUtenteModule { }


  
