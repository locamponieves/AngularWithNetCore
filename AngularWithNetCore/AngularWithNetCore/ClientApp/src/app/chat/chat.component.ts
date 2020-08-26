import { Component } from '@angular/core';

@Component({
    selector: 'chat-app',
    templateUrl: './chat.component.html'
})

export class ChatComponent {
    public nombre = 'Leonis Ocampo Nieves'

    public CambiaNombre() {
        this.nombre = "faltaelpuntoycoma.com"
    }
}