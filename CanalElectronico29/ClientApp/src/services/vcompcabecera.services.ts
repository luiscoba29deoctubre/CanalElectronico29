import { HttpClient } from "@angular/common/http";
import { Inject } from "@angular/core";
import { Observable } from "rxjs";

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

  updateEmployee(value: any): Observable<Record<string, any>> {
    return this.httpobj.put<Tposcompensacabecera>(
      this.appurl + "api/v1/VCompensaCabecera/EditTcompensacabecera",
      value
    );
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
