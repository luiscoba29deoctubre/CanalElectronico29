import { Injectable } from "@angular/core";
import { HttpHeaders } from "@angular/common/http";
import { MsalUserService } from "./msaluser.service";

@Injectable({
  providedIn: "root",
})
export class DataService {
  httpOptions = {
    headers: new HttpHeaders({
      "Content-Type": "application/json",
    }),
  };

  constructor(private msalService: MsalUserService) {}

  getCurrentUserInfo() {
    this.msalService.getCurrentUserInfo();
  }

  logout() {
    this.msalService.logout();
  }
}
