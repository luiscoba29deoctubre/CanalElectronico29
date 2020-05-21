import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-parametrizacion",
  templateUrl: "./parametrizacion.component.html",
  styleUrls: ["./parametrizacion.component.css"],
})
export class ParametrizacionComponent {
  parametrizacion: string[] = ["Ejecutar Query"];
  selectedParametrizacion = this.parametrizacion[0];
}
