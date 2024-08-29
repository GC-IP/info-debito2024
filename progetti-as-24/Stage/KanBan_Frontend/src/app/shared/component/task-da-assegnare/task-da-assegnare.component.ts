import { Component, NgModule, OnInit } from '@angular/core';
import { Task } from '../../../models/task';//???
import { TasksService } from '../../services/tasks.service';//???

@Component({
  selector: 'app-task-da-assegnare',
  templateUrl: './task-da-assegnare.component.html',
  styleUrl: './task-da-assegnare.component.css'
})
export class TaskDaAssegnareComponent implements OnInit{

  listaTasks: Task[] | undefined;
  constructor(
    private tasksService: TasksService
  ){

  }


   ngOnInit(): void {
    this.tasksService.listDaAssegnare().subscribe(res => this.listaTasks = res);
   }

   AssegnaTask(task:Task) {
   // task.
   }
}

@NgModule({
  imports: [ 
   ],
   declarations: [ TaskDaAssegnareComponent ],
   exports:    [ TaskDaAssegnareComponent ]
})

export class TaskDaAssegnareModule { }

