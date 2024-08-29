import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { provideHttpClient } from '@angular/common/http';
import { AppComponent } from './app.component';
import { UtentiService } from './shared/services/utenti.service';
import { TaskAssegnatiUtenteModule } from './shared/component/task-assegnati-utente/task-assegnati-utente.component';
import { BrowserModule } from '@angular/platform-browser';



@NgModule({
  imports: [
    CommonModule, BrowserModule
  ],
  declarations: [
    AppComponent, UtentiService
 ],
  providers: [provideHttpClient()],
  bootstrap: [ AppComponent ]
})
export class AppModule {} 

