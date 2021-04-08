namespace InheritanceTask
{
    public class JuniorManager : Manager
    {
        private int workHour;
        // private static decimal bonus = 300M;
        public JuniorManager(string name, decimal monthlyBase, int workHour) : base(name, monthlyBase, 300M)
        {
            WorkHour = workHour;
        }
        public int WorkHour 
        {
            get { return workHour; }
            private set {
                            if (value > 0)
                            {
                                workHour = value; 
                            }else
                            {
                                throw new System.ArgumentOutOfRangeException();
                            }
                        }
        }

        public override decimal GetSalary()
        {
            return WorkHour >= 180? BaseSalary + Bonus: BaseSalary;
        }

        
    }
}