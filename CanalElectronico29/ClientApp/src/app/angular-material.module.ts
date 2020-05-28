import { NgModule } from "@angular/core";

import {
  MatToolbarModule,
  MatTableModule,
  MatCheckboxModule,
  MatPaginatorModule,
  MatSortModule,
  MatButtonModule,
  MatInputModule,
} from "@angular/material";

@NgModule({
  imports: [
    MatToolbarModule,
    MatTableModule,
    MatCheckboxModule,
    MatPaginatorModule,
    MatSortModule,
    MatButtonModule,
    MatInputModule,
  ],
  exports: [
    MatToolbarModule,
    MatTableModule,
    MatCheckboxModule,
    MatPaginatorModule,
    MatSortModule,
    MatButtonModule,
    MatInputModule,
  ],
})
export class AngularMaterialModule {}
