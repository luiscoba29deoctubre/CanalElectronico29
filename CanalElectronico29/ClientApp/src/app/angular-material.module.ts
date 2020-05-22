import { NgModule } from "@angular/core";

import {
  MatToolbarModule,
  MatTableModule,
  MatCheckboxModule,
  MatPaginatorModule,
  MatSortModule,
  MatButtonModule,
} from "@angular/material";

@NgModule({
  imports: [
    MatTableModule,
    MatPaginatorModule,
    MatCheckboxModule,
    MatSortModule,
    MatToolbarModule,
    MatButtonModule,
  ],
  exports: [
    MatTableModule,
    MatPaginatorModule,
    MatCheckboxModule,
    MatSortModule,
    MatToolbarModule,
    MatButtonModule,
  ],
})
export class AngularMaterialModule {}
