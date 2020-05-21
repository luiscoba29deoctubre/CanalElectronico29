// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  baseUrl: "http://localhost:58980/",
  scopeUri: ["api://915e0de9-08c2-4311-bc03-ccaa735ac5e7/canal"],
  tenantId: "f8733e19-5615-4258-907e-cb8c982ffc34",
  uiClienId: "915e0de9-08c2-4311-bc03-ccaa735ac5e7",
  redirectUrl: "http://localhost:5000", //cambiamos de 4200 a 5000
};

/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
