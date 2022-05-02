using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VentasReal_Ws.Data;
using VentasReal_Ws.Data.Requests;
using VentasReal_Ws.Data.Responses;
using VentasReal_Ws.Models;

namespace VentasReal_Ws.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET: api/Cliente
        [HttpGet]
        public IActionResult Get()
        {
            var response = new Response();
            try
            {
                using var db = new AppDbContext();
                var lst = db.Clientes.ToList();
                response.IsSuccess = true;
                response.Result = lst;

            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return Ok(response);

        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var response = new Response();
            try
            {
                using var db = new AppDbContext();
                var lst = db.Clientes.Where(c => c.Id == id).ToList();
                response.IsSuccess = true;
                response.Result = lst;

            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return Ok(response);
        }

        // ADD: api/Cliente
        [HttpPost]
        public IActionResult Post([FromBody] ClienteRequest rModel)
        {
            var response = new Response();
            try
            {
                using var db = new AppDbContext();
                if (rModel.Id > 0)
                {
                    response.Message = "No se puede insertar un registro cuya ID es mayor a cero";
                }
                else
                {
                    var model = new Cliente
                    {
                        Nombre = rModel.Nombre
                    };
                    db.Clientes.Add(model);
                    db.SaveChanges();
                    response.IsSuccess = true;
                }
                
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return Ok(response);
        }
        
        // PUT: api/Cliente/5
        [HttpPut]
        public IActionResult Put([FromBody] ClienteRequest rModel)
        {
            var response = new Response();
            try
            {
                using var db = new AppDbContext();
                if (rModel.Id > 0)
                {
                    var model = db.Clientes.Find(rModel.Id);
                    if (model != null)
                    {
                        model.Nombre = rModel.Nombre;
                        db.Clientes.Update(model);
                        db.SaveChanges();
                        response.IsSuccess = true;
                    }
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return Ok(response);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = new Response();
            try
            {
                using var db = new AppDbContext();
                var model = db.Clientes.Find(id);
                if (model != null)
                {
                    db.Clientes.Remove(model);
                    db.SaveChanges();
                    response.IsSuccess = true;
                }
                else
                {
                    response.Message = "No se encontro el registro para eliminar";
                }

            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return Ok(response);
        }
    }
}
