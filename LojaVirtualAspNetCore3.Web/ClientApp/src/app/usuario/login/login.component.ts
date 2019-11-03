import { Component } from "@angular/core";
import { Usuario } from "../../model/usuario";

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls : ["./login.component.css"]
})
export class LoginComponent {
    public usuario = new Usuario();
    public usuarioAutenticado: boolean = false;
    
    constructor() {
        this.usuario = new Usuario();
    }
   
    
    entrar() {
        if (this.usuario.email == "wes@wes.com" && this.usuario.senha == "12345") {
            this.usuarioAutenticado = true;
        }
       
    }
    

}
