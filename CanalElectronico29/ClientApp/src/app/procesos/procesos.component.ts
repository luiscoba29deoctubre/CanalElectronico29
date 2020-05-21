import { Component } from "@angular/core";

@Component({
  selector: "app-procesos",
  templateUrl: "./procesos.component.html",
  styleUrls: ["./procesos.component.css"],
})
export class ProcesosComponent {
  procesos: string[] = ["Procesos", "Pos"];
  selectedProceso = this.procesos[0];
  procesos2: string[] = [
    "Carga Desbloqueos",
    "Carga Procesos",
    "Convicencia SIFCO-FITBANK",
    "Autorización de Procesos",
    "Carga Recuperación SIFCO",
  ];
  selectedProceso2 = this.procesos2[0];
  pos: string[] = ["Aprobación Compesación", "Cargar Archivos Compesación"];
  selectedPos = this.pos[0];
}
