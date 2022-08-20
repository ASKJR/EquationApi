namespace EquationApi.Models
{
    public class Equation
    {
        private readonly string[] operators = new string[] { "+", "-", "*" };
        private const int MIN_VALUE = 1, MAX_VALUE = 11;
        public int NumberOne { get; }
        public int NumberTwo { get; }
        public string Operator { get; } = String.Empty;
        public int Answer { get; }

        public Equation()
        {
            NumberOne = GetRandomNumber();
            NumberTwo = GetRandomNumber();
            Operator = operators[GetRandomNumber(min:0, max:3)];
            Answer = SolveEquation(NumberOne, NumberTwo, Operator);
        }

        private static int GetRandomNumber(int? min = null, int? max = null)
        {
            
            if (min is not null && max is not null)
            {
                return Random.Shared.Next((int)min, (int)max);
            }

            return Random.Shared.Next(MIN_VALUE, MAX_VALUE);
        }

        private static int SolveEquation(int numberOne, int numberTwo, string op)
        {
            return op switch
            {
                "+" => numberOne + numberTwo,
                "-" => numberOne - numberTwo,
                "*" => numberOne * numberTwo,
                _ => -1,
            };
        }

    }
}
