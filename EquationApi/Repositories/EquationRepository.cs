using EquationApi.Models;

namespace EquationApi.Repositories
{
    public class EquationRepository : IEquationRepository
    {
        private static readonly IEnumerable<Equation> equations = 
            Enumerable.Range(1, 51).Select(index => new Equation());

        public IEnumerable<Equation> GetEquations(int take)
        {
            if (take <= 0 || take > 50) take = 10;
            return equations.Take(take);
        }
    }
}
