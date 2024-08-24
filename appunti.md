# Appunti vari sui prigetti di recupero

## Progetti di tipo API

- hanno backend fatto in VS 2022; progetti di tipo Web API .Net 8
- hanno frontend fatto in VS Code; progetti Angular

### Esecuzione (runtime)

- I progetti .Net per funzionare hanno bisogno di un runtime .Net (.Net runtime)
- I progetti Angular funzionano nel browser (sono fatti in HTML/CSS/JS), ma vengono sviluppati come progetti Node.js. Viene installata una CLI (la Angular CLI) che provvede a compilare il codice (scritto in typescript e HTML/CSS) per poter essere visuaizzato da un browser
- Front e back comunicano tramite HTTP, quindi ci sono due web server, uno per il back e uno per il front
- il browser contatta il web server del front (che si avvia con il comando della CLI ```ng s```) e ottiene l'intera applicazione web; in questa applicazione ci sono delle chiamate al web server dell'API (*AJAX fatte con l'oggetto *HttpXMLRequest, che viene gestito interamente da Angular).

## Definizioni

- AJAX: Asynchronous Javascript And XML; tecnica di comunicazione tra applicazione web e API
- XHR: HttpXMLRequest; è l'oggetto in Javascript capace di fare chiamate HTTP e di ricevere le relative risposteù
- Angular crea Single Page Applications "SPA"
- DOM: albero di tutti i tag dell'applicazione

## Info varie
- Carattere backtick: ` (alt + numpad 9 + numpad 6)