using System;
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
        [Route("EditTcompensacabecera2")]
        public int EditTposcompensacabecera2([FromBody] List<Tposcompensacabecera> lstTposcompensacabecera)
        {
            Console.WriteLine("Se lanza EditTcompensacabecera ");
            Console.WriteLine("Se lanza EditTcompensacabecera {0} ",
                              lstTposcompensacabecera);

            List<int> lstIdsTposcompensacabecera = new List<int>();

            foreach (Tposcompensacabecera tposcompensacabecera in lstTposcompensacabecera)
            {
                lstIdsTposcompensacabecera.Add(tposcompensacabecera.Id);
            }

            return dbvCompensaCabecera.UpdateTcompensacabecera(lstIdsTposcompensacabecera);
        }


        // PUT: api/BlogPosts/5
        /*        [HttpPut]
                [Route("EditTcompensacabecera")]
                public async Task<IActionResult> EditTposcompensacabecera(TransaccionLog asdf)//(TransaccionLog transaccion)
                {
                    int x = 0;

                    return NoContent();
                }
        */

        [HttpGet]
        [Route("GetVcompensaCabecera")]
        public async Task<IEnumerable<Vposcompensacabecera>> GetAllvCompensaCabecera()
        {
            Console.WriteLine("Se lanza GetVcompensaCabecera ");

            return await dbvCompensaCabecera.GetAllvCompensaCabecera();
        }

    }
}