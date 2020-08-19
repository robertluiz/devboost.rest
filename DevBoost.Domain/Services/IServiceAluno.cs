using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBoost.Domain
{
    public interface IServiceAluno
    {
        bool Create(AlunoModel alunoModel);

        bool Update(AlunoModel alunoModel);

        List<AlunoModel> Get();

        bool Delete(int id);
    }
}