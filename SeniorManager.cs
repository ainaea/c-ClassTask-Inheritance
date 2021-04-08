namespace InheritanceTask
{
    public class SeniorManager : Manager
    {
        private int evaluations;
        public SeniorManager(string name, decimal baseSalary, decimal bonus, int evaluations) : base(name, baseSalary, bonus)
        {
            Evaluations = evaluations;
        }
        public int Evaluations
        {
            get { return evaluations; }
            private set {
                    if (value >= 0)
                    {
                        evaluations = value; 
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
        }
        public override decimal GetSalary()
        {
            return Evaluations >= 6? BaseSalary + Bonus: BaseSalary;
        }

        
    }
}