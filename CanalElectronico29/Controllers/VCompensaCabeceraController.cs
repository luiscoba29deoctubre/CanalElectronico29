using System.Collections.Generic;
using System.Threading.Tasks;
using CanalElectronico29.DataAccess;
using CanalElectronico29.Models;
using Microsoft.AspNetCore.Mvc;

namespace CanalElectronico29.Controllers
{
    [Route("api/v1/VCompensaCabecera")]
    public class VCompensaCabeceraController : Controller
    {
        private readonly DAvCompensaCabecera dbvCompensaCabecera = new DAvCompensaCabecera();

        [HttpPut]
        [Route("EditTcompensacabecera")]
        public int EditTposcompensacabecera([FromBody] List<int> lstIdsTposcompensacabecera)
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            //           return dbvCompensaCabecera.UpdateTcompensacabecera(lstTposcompensacabecera);
            return dbvCompensaCabecera.UpdateTcompensacabecera(l);
        }

        [HttpPost]
        [Route("AddEmployee")]
        public int AddEmployee([FromBody] Tposcompensacabecera employee)
        {
            return dbvCompensaCabecera.AddEmployee(employee);
        }
        [HttpGet]
        [Route("GetVcompensaCabecera")]
        public async Task<IEnumerable<Vposcompensacabecera>> GetAllvCompensaCabecera()
        {
            return await dbvCompensaCabecera.GetAllvCompensaCabecera();
        }

    }
}