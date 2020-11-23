using Corretores.Business;
using Corretores.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Runtime;

namespace Corretores.Controllers
{
    [Produces("application/json")]
    public class CorretorController : Controller
    {
        string _tokenapi = "978a49b877240213b822b42ae330db2b";
        [HttpPost]
        public JsonResult Add([FromBody] CorretorEntity corretor)
        {
            string _token = "";
            var header = Request.Headers;

            _token = header["token-corretor"];
            if (!_token.Equals(_tokenapi))
            {
                return Json("Token invalido");
            }

            CorretorBusiness busines = new CorretorBusiness();
            return Json(busines.Add(corretor));
        }
        public JsonResult testeapi()
        {
            string _token = "";
            var header = Request.Headers;

            _token = header["token-corretor"];
            if (!_token.Equals(_tokenapi))
            {
                return Json("Token invalido");
            }

            return Json("deu certo");
        }
        public JsonResult GetbyId (int id)
        {
            string _token = "";
            var header = Request.Headers;

            _token = header["token-corretor"];
            if (!_token.Equals(_tokenapi))
            {
                return Json("Token invalido");
            }

            CorretorBusiness busines = new CorretorBusiness();
            return Json(busines.GetById(id));
        }
        public JsonResult Update(CorretorEntity corretor)
        {
            string _token = "";
            var header = Request.Headers;

            _token = header["token-corretor"];
            if (!_token.Equals(_tokenapi))
            {
                return Json("Token invalido");
            }

            CorretorBusiness busines = new CorretorBusiness();
            return Json(busines.Update(corretor));
        }
        public JsonResult Remove (CorretorEntity corretor)
        {
            string _token = "";
            var header = Request.Headers;

            _token = header["token-corretor"];
            if (!_token.Equals(_tokenapi))
            {
                return Json("Token invalido");
            }

            CorretorBusiness busines = new CorretorBusiness();
            return Json(busines.Remove(corretor));
        }
    }
}
