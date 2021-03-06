import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from "@angular/core";
import { MsalModule, MsalInterceptor } from "@azure/msal-angular";
import {
  HttpClientModule,
  HttpClient,
  HTTP_INTERCEPTORS,
} from "@angular/common/http";
import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { MsalUserService } from "./services-msal/msaluser.service";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { ProcesosComponent } from "./procesos/procesos.component";
import { ParametrizacionComponent } from "./parametrizacion/parametrizacion.component";
import { EstructurasComponent } from "./estructuras/estructuras.component";
import { ConsultasComponent } from "./consultas/consultas.component";
import { CajasComponent } from "./cajas/cajas.component";
import { VcompensacabeceraComponent } from "./vcompensacabecera/vcompcabecera.component";
import { environment } from "src/environments/environment";
import { VcompcabeceraServices } from "src/services/vcompcabecera.services";
import { AngularMaterialModule } from "./angular-material.module";
import { HeaderComponent } from "./header/header.component";

import { MAT_FORM_FIELD_DEFAULT_OPTIONS } from "@angular/material/form-field";

export const protectedResourceMap: any = [
  [environment.baseUrl, environment.scopeUri],
];

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    ProcesosComponent,
    ParametrizacionComponent,
    EstructurasComponent,
    ConsultasComponent,
    CajasComponent,
    VcompensacabeceraComponent,
    HeaderComponent,
  ],
  imports: [
    MsalModule.forRoot({
      clientID: environment.uiClienId,
      authority: "https://login.microsoftonline.com/" + environment.tenantId,
      cacheLocation: "localStorage",
      protectedResourceMap: protectedResourceMap,
      redirectUri: environment.redirectUrl,
    }),
    AngularMaterialModule,
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: "cajas", component: CajasComponent },
      { path: "consultas", component: ConsultasComponent },
      { path: "estructuras", component: EstructurasComponent },
      { path: "parametrizacion", component: ParametrizacionComponent },
      { path: "procesos", component: ProcesosComponent },
      { path: "vcabecera", component: VcompensacabeceraComponent },
    ]),
    BrowserAnimationsModule,
  ],
  providers: [
    {
      provide: MAT_FORM_FIELD_DEFAULT_OPTIONS,
      useValue: { appearance: "fill" },
    },
    VcompcabeceraServices,
    HttpClient,
    MsalUserService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: MsalInterceptor,
      multi: true,
    },
  ],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AppModule {}
