/*import { Component, ViewChild } from "@angular/core";
import {
  VcompcabeceraDataModel,
  VcompcabeceraServices,
} from "src/services/vcompcabecera.services";
import { MatPaginator, MatSort, MatTableDataSource } from "@angular/material";

@Component({
  selector: "app-vcompensacabecera",
  templateUrl: "./vcompcabecera.component.html",
  styleUrls: ["./vcompcabecera.component.css"],
})
export class VcompensacabeceraComponent {
  public vCompensaCabeceraList: VcompcabeceraDataModel[];
  ELEMENT_DATA: VcompcabeceraDataModel[];
  items = [];
  selectedList = [];
  dataSource = new MatTableDataSource<VcompcabeceraDataModel>();

  constructor(private serviceVcompensaCabecera: VcompcabeceraServices) {
    this.getAllVcompensaCabecera();
  }

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  ngOnInit() {
    console.log("compensaCabeceraList", this.vCompensaCabeceraList);

    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
  /*
  ngAfterViewInit() {
    this.accountService.getAccounts().subscribe(data => {
      this.dataSource.data = data;
      console.log(this.dataSource.data);
    });
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }*/
/*
  getAllVcompensaCabecera() {
    this.serviceVcompensaCabecera
      .getAllVcompensaCabecera()
      .subscribe((data) => {
        console.log("compensaCab ", data);
        this.vCompensaCabeceraList = data;

        this.ELEMENT_DATA = this.vCompensaCabeceraList;
        //  this.dataSource = this.ELEMENT_DATA;

        // this.dataSource = new MatTableDataSource(this.ELEMENT_DATA);
        this.dataSource = new MatTableDataSource<VcompcabeceraDataModel>(
          this.ELEMENT_DATA
        );

        console.log("this.ELEMENT_DATA ", this.ELEMENT_DATA);
        console.log("this.dataSource", this.dataSource);
      });
  }

  onCheckboxChange(event) {
    console.log("cheeeeeeee", event.target.value);
    let value;
    let valueToDelete;
    if (event.target.checked) {
      value = this.vCompensaCabeceraList.find(
        (item) => item.id == event.target.value
      );
      this.selectedList.push(value);
    } else {
      console.log(this.selectedList);
      console.log(event.target.value);
      valueToDelete = this.selectedList.find(
        (item) => item.id == event.target.value
      );
      console.log("-----", valueToDelete);
      this.selectedList.splice(this.selectedList.indexOf(valueToDelete), 1);
    }
  }
  displayedColumns: string[] = ["position", "name", "weight", "symbol"];
}
*/
import { Component, ViewChild } from "@angular/core";
import { MatPaginator, MatSort, MatTableDataSource } from "@angular/material";
import {
  VcompcabeceraDataModel,
  VcompcabeceraServices,
} from "src/services/vcompcabecera.services";

@Component({
  selector: "app-vcompensacabecera",
  templateUrl: "./vcompcabecera.component.html",
  styleUrls: ["./vcompcabecera.component.css"],
})
export class VcompensacabeceraComponent {
  displayedColumns: string[] = [
    "select",
    "position",
    "name",
    "weight",
    "symbol",
  ];
  dataSource = new MatTableDataSource<VcompcabeceraDataModel>();
  public vCompensaCabeceraList: VcompcabeceraDataModel[];
  items = [];
  selectedList = [];

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
        this.vCompensaCabeceraList = data;
        this.dataSource.data = data;
      });
  }

  onCheckboxChange(event) {
    console.log("cheeeeeeee", event.target.value);
    let value;
    let valueToDelete;
    if (event.target.checked) {
      value = this.vCompensaCabeceraList.find(
        (item) => item.id == event.target.value
      );
      this.selectedList.push(value);
    } else {
      console.log(this.selectedList);
      console.log(event.target.value);
      valueToDelete = this.selectedList.find(
        (item) => item.id == event.target.value
      );
      console.log("-----", valueToDelete);
      this.selectedList.splice(this.selectedList.indexOf(valueToDelete), 1);
    }
  }
}
