using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBoost.Domain.Services
{
    public class ServiceAluno : IServiceAluno
    {
        
        public bool Create(AlunoModel alunoModel)
        {
            return true;
        }

        public bool Update(AlunoModel alunoModel)
        {
            return true;
        }

        public List<AlunoModel> Get()
        {
            return new List<AlunoModel>
            {
                new AlunoModel
                {
                    Nome = "Robert",
                    Email = "robert.tiweb@gmail.com",
                    Id = Guid.NewGuid()
                },
                new AlunoModel
                {
                    Nome = "Italo Farias",
                    Email = "italovinicios@gmail.com",
                    Id = Guid.NewGuid()
                },
                new AlunoModel
                {
                    Nome = "Guilherme",
                    Email = "guilherme_cupertino@hotmail.com",
                    Id = Guid.NewGuid()
                }

            };
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}
