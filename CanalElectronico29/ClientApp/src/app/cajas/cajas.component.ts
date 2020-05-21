import { Component, Input } from "@angular/core";

@Component({
  selector: "app-cajas",
  templateUrl: "./cajas.component.html",
  styleUrls: ["./cajas.component.css"],
})
export class CajasComponent {
  cajas: string[] = ["Pagos COSEDE", "Reimpresión COSEDE"];
  selectedCaja = this.cajas[0];
}
