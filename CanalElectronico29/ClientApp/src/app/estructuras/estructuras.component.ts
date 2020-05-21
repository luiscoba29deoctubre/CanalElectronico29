import { Component } from "@angular/core";

@Component({
  selector: "app-estructuras",
  templateUrl: "./estructuras.component.html",
  styleUrls: ["./estructuras.component.css"],
})
export class EstructurasComponent {
  estructuras: string[] = [
    "Estructura UAF",
    "Estructuras Operaciones",
    "Estructura I'S",
    "Estructura Compesación",
    "Carga de Archivo SPI 4",
  ];
  selectedEstructura = this.estructuras[0];
}
