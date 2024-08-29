import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TaskDaAssegnareModule } from './shared/component/task-da-assegnare/task-da-assegnare.component';
import { TaskAssegnatiModule } from './shared/component/task-assegnati/task-assegnati.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,  TaskDaAssegnareModule, TaskAssegnatiModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'KanBan_Frontend';
}
