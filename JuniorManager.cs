namespace InheritanceTask
{
    public class JuniorManager : Manager
    {
        private int workHour;
        public JuniorManager(string name, decimal monthlyBase, decimal bonus, int workHour) : base(name, monthlyBase, bonus)
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