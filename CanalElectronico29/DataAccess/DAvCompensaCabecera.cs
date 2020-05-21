using System.Collections.Generic;
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

        public int UpdateCabecera(Tposcompensacabecera cabecera)
        {
            try
            {
                dBBUSINTEGRACIONContext.Entry(cabecera).State = EntityState.Modified;
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