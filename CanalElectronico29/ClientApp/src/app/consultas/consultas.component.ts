import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-consultas",
  templateUrl: "./consultas.component.html",
  styleUrls: ["./consultas.component.css"],
})
export class ConsultasComponent {
  consultas: string[] = [
    "Consulta Procesos",
    "Consulta Compesación",
    "Consulta Comprobantes Electronicos",
  ];
  selectedConsulta = this.consultas[0];
}
