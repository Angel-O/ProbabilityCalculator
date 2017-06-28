namespace ProbabilityCalculator.Models.Calculation
{
    /// <summary>
    /// Calculates <see cref="EitherCalculation"/> probabilities
    /// </summary>
    public class EitherCalculation : BinaryCalculationBase {

        public EitherCalculation(double op1, double op2): base (op1, op2) { }

        /// <summary>
        /// <see cref="ICalculation.Calculate"/>
        /// </summary>
        public override double Calculate()
        {
            return Op1 + Op2 - Op1 * Op2;
        }
    }
}