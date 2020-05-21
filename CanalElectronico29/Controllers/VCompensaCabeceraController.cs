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

        [HttpGet]
        [Route("GetVcompensaCabecera")]
        public async Task<IEnumerable<Vposcompensacabecera>> GetAllvCompensaCabecera()
        {
            return await dbvCompensaCabecera.GetAllvCompensaCabecera();
        }
    }
}