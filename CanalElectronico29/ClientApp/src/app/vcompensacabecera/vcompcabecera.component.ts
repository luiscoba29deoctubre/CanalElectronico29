import { Component, ViewChild } from "@angular/core";
import { MatPaginator, MatSort, MatTableDataSource } from "@angular/material";
import {
  VcompcabeceraDataModel,
  VcompcabeceraServices,
} from "src/services/vcompcabecera.services";
import { SelectionModel } from "@angular/cdk/collections";

@Component({
  selector: "app-vcompensacabecera",
  templateUrl: "./vcompcabecera.component.html",
  styleUrls: ["./vcompcabecera.component.css"],
})
export class VcompensacabeceraComponent {
  displayedColumns: string[] = [
    "select", //cambiar a autorizar
    "fproceso",
    "convenio",
    "nombre",
    "fautorizacion",
    "usuarioautorizacion",
    "error",
    "estado",
    "registros",
    "compensados",
    "rechazados",
    "Totaltransaccion",
    "Totalliquidado",
    "Totalcomision",
  ];

  dataSource = new MatTableDataSource<VcompcabeceraDataModel>();
  selection = new SelectionModel<VcompcabeceraDataModel>(true, []);
  selectedList = [];

  // public vCompensaCabeceraList: VcompcabeceraDataModel[];

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  constructor(private serviceVcompensaCabecera: VcompcabeceraServices) {
    this.getAllVcompensaCabecera();
  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  getAllVcompensaCabecera() {
    this.serviceVcompensaCabecera
      .getAllVcompensaCabecera()
      .subscribe((data) => {
        console.log("compensaCab ", data);
        this.dataSource.data = data;
      });
  }

  // FILTRO

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  // MéTODOS PARA SELECCIONAR Y DESELECCIONAR LOS CHECKS

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected()
      ? ((this.selectedList = []), this.selection.clear())
      : ((this.selectedList = this.dataSource.data),
        this.dataSource.data.forEach((row) => this.selection.select(row)));

    console.log("this.selectedList ", this.selectedList);
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: VcompcabeceraDataModel): string {
    if (!row) {
      return `${this.isAllSelected() ? "select" : "deselect"} all`;
    }
    return `${this.selection.isSelected(row) ? "deselect" : "select"} row ${
      row.id
    }`;
  }
  /**
   *
   * @param event // es el evento
   * @param row // el la fila seleccionada
   */
  eventCheck(event, row) {
    if (event.checked) {
      this.selectedList.push(row);
    } else {
      this.selectedList.splice(this.selectedList.indexOf(row), 1);
    }
    console.log("this.selectedList ", this.selectedList);
  }
}
