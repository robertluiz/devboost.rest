using DevBoost.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Rest.Controllers
{
    [Route("api/aluno")]
    public class AlunoController : Controller
    {
        private readonly IServiceAluno _alunoService;
        public AlunoController(IServiceAluno alunoService)
        {
            _alunoService = alunoService;
        }


        public ActionResult Get()
        {
            return Ok(_alunoService.Get());
        }

        [HttpPost]
        public ActionResult Post(AlunoModel aluno)
        {
            return Ok(_alunoService.Create(aluno));

        }

        [HttpPut]
        public ActionResult Put(AlunoModel aluno)
        {
            return Ok(_alunoService.Update(aluno));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(_alunoService.Delete(id));
        }

       
    }
}
