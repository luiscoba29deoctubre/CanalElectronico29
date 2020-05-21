import { Component, OnInit } from "@angular/core";
import {
  VcompensaCabeceraDataModel,
  VCompensaCabeceraServices,
} from "src/services/vCompensaCabecera.services";

@Component({
  selector: "app-vcompensacabecera",
  templateUrl: "./vcompensacabecera.component.html",
  styleUrls: ["./vcompensacabecera.component.css"],
})
export class VcompensacabeceraComponent implements OnInit {
  public vCompensaCabeceraList: VcompensaCabeceraDataModel[];
  items = [];
  selectedList = [];
  constructor(private serviceVcompensaCabecera: VCompensaCabeceraServices) {
    this.getAllVcompensaCabecera();
  }

  ngOnInit() {
    console.log("compensaCabeceraList", this.vCompensaCabeceraList);
  }

  getAllVcompensaCabecera() {
    this.serviceVcompensaCabecera
      .getAllVcompensaCabecera()
      .subscribe((data) => {
        console.log("compensaCab ", data);
        this.vCompensaCabeceraList = data;
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
