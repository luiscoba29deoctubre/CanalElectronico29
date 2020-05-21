import { Component } from "@angular/core";
import { DataService } from "./services-msal/data.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  title = "AzureMSALAngular";

  errorMessage: any;

  constructor(private dataService: DataService) {}

  ngOnInit(): void {}

  getUser() {
    this.dataService.getCurrentUserInfo();
  }

  logout() {
    this.dataService.logout();
  }
}
