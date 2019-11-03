import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
    }


    public usuarioLogado(): boolean {
        return sessionStorage.getItem("usuario-autenticado") == "1";
    }
    constructor(private router: Router) {

}
    sair() {
        sessionStorage.setItem("usuario-autenticado", "");
        this.router.navigate(['/']);
    }
}
