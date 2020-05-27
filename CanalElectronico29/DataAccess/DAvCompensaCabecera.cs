using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CanalElectronico29.Models;
using Microsoft.EntityFrameworkCore;

namespace CanalElectronico29.DataAccess
{
    public class DAvCompensaCabecera
    {
        DBBUSINTEGRACIONContext dBBUSINTEGRACIONContext = new DBBUSINTEGRACIONContext();
        public async Task<IEnumerable<Vposcompensacabecera>> GetAllvCompensaCabecera()
        {
            try
            {
                return await dBBUSINTEGRACIONContext.Vposcompensacabecera.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public int UpdateTcompensacabecera(List<int> lstIdsTposcompensacabecera)
        {
            try
            {
                /*  foreach (var tcabecera in lstTposcompensacabecera)
                  {
                      dBBUSINTEGRACIONContext.Entry(tcabecera).State = EntityState.Modified;
                      dBBUSINTEGRACIONContext.SaveChanges();
                  }*/

                /*            using (var context = new DBBUSINTEGRACIONContext())
                            {
                                context.Tposcompensacabecera
                                .Where(x => lstIdsTposcompensacabecera.Contains(x.Id))
                                .Update(x => new Tposcompensacabecera { Convenio = 222, Cestado = "Updated" });

                            }*/


                using (var db = new DBBUSINTEGRACIONContext())
                {
                    var myData = db.Tposcompensacabecera.Where(x => lstIdsTposcompensacabecera.Contains(x.Id)).ToList();
                    myData.ForEach(m => m.Cestado = "xy");
                    db.SaveChanges();
                }

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int AddEmployee(Tposcompensacabecera employee)
        {
            try
            {
                dBBUSINTEGRACIONContext.Tposcompensacabecera.Add(employee);
                dBBUSINTEGRACIONContext.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}