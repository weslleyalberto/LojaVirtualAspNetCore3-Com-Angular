import { Component } from "@angular/core"

@Component({
    selector: "produto",
    template : "<html><body> {{obterNome() }}</body></html>"
})
export class ProdutoComponet {
    public nome: string;
    public liberadoParaVenda: boolean;


    public obterNome(): string {
        return "Weslley PEreira Alberto";
    }

}
