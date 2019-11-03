import { Component } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { Router } from "@angular/router";

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls : ["./login.component.css"]
})
export class LoginComponent {
    public usuario = new Usuario();
    public usuarioAutenticado: boolean = false;

    constructor(private router: Router) {
        this.usuario = new Usuario();
    }
   
    
    entrar() {
        if (this.usuario.email == "wes@wes.com" && this.usuario.senha == "123456") {
            sessionStorage.setItem("usuario-autenticado", "1");
            this.router.navigate(['/'])
        }
       
    }
    

}
