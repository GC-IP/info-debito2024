import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
    selector: 'app-elenco-menu',
    standalone: true,
    imports: [
        CommonModule,
    ],
    templateUrl: 'elenco-menu.component.html',
    styleUrl: './elenco-menu.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ElencoMenuComponent { }
