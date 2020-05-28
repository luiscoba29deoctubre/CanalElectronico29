import { HttpClient } from "@angular/common/http";
import { Inject } from "@angular/core";
import { Observable, throwError } from "rxjs";
import { catchError } from "rxjs/operators";

export class VcompcabeceraServices {
  appurl = "";

  constructor(
    private httpobj: HttpClient,
    @Inject("BASE_URL") _baseurl: string
  ) {
    this.appurl = _baseurl;
  }

  getAllVcompensaCabecera(): Observable<VcompcabeceraDataModel[]> {
    return this.httpobj.get<VcompcabeceraDataModel[]>(
      this.appurl + "api/v1/VCompensaCabecera/GetVcompensaCabecera"
    );
  }

  updateEmployee(
    lstTposcompensacabecera: Tposcompensacabecera[]
  ): Observable<any> {
    console.log("value ", lstTposcompensacabecera);
    return this.httpobj
      .put<any>(
        this.appurl + "api/v1/VCompensaCabecera/EditTcompensacabecera2",
        lstTposcompensacabecera
      )
      .pipe(
        catchError((response) => {
          console.log("response llega ", { response });
          if (response.status == 400) {
            return throwError(response);
          }
          if (response.error.mensaje) console.log(response.error.mensaje);

          return throwError(response);
        })
      );
  }

  errorHandler(error) {
    let errorMessage = "";
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }
}

export interface VcompcabeceraDataModel {
  id: number;
  fproceso: Date;
  convenio: number;
  nombre: string;
  fautorizacion: Date;
  cusuarioautorizacion: string;
  usuarioautorizacion: string;
  error: string;
  transferencia: string;
  comision: string;
  retencionfte: string;
  retencioniva: string;
  cestado: string;
  estado: string;
  registros?: number;
  compensados?: number;
  rechazados?: number;
  Totaltransaccion: number;
  Totalliquidado: number;
  Totalcomision: number;
  Totalivacomision: number;
  Totalretencionfte: number;
  Totalretencioniva: number;
}

export interface Tposcompensacabecera {
  Id: number;
  Idconvenio?: number;
  Fproceso: Date;
  Convenio: number;
  Cestado: string;
  Fautorizacion?: Date;
  Cusuarioautorizacion: string;
  Transferencia: string;
  Comision: string;
  Retencionfte: string;
  Retencioniva: string;
  Error: string;
}
