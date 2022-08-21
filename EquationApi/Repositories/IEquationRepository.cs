using EquationApi.Models;

namespace EquationApi.Repositories
{
    public interface IEquationRepository
    {
        IEnumerable<Equation> GetEquations(int take);
    }
}
