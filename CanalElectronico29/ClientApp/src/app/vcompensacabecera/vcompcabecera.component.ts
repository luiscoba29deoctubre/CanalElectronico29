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
  isFilter;

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
        this.dataSource.data = data;
      });
  }

  // FILTRO
  applyFilter(event: Event) {
    this.isFilter = true;
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
    console.log("this.dataSource.filteredData", this.dataSource.filteredData);
    console.log("1this.selectedList ", this.selectedList);
    this.selectedList = [];
    this.selectedList = this.dataSource.filteredData;
    console.log("2this.selectedList ", this.selectedList);
  }

  // MéTODOS PARA SELECCIONAR Y DESELECCIONAR LOS CHECKS

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  /*masterToggle() {
    this.isAllSelected()
      ? this.selection.clear()
      : this.dataSource.data.forEach((row) => this.selection.select(row));

    console.log("this.selectedList ", this.selectedList);
  }*/

  masterToggle() {
    /*    if (this.isFilter) {
      this.isAllSelected()
        ? ((this.selectedList = []), this.selection.clear())
        : this.dataSource.filteredData.forEach((row) =>
            this.selection.select(row)
          );
      /*   } else {
      this.isAllSelected()
        ? ((this.selectedList = []), this.selection.clear())
        : this.dataSource.data.forEach((row) => this.selection.select(row));
        */
    /*    }
    console.log("this.selectedList ", this.selectedList);
*/

    this.isAllSelected()
      ? ((this.selectedList = []), this.selection.clear())
      : ((this.selectedList = this.isFilter
          ? this.dataSource.filteredData
          : this.dataSource.data),
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

  // BUTTON
  onSave($event) {
    console.log("Save button is clicked!", $event);
    this.serviceVcompensaCabecera.updateEmployee(this.selectedList);
  }
}
