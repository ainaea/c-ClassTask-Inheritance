namespace InheritanceTask
{
    public abstract class Manager : Employee
    {
        private decimal baseSalary;
        private decimal bonus;
        public Manager(string name, decimal basePay, decimal bonusPay) : base(name)
        {
            BaseSalary = basePay;
            Bonus = bonusPay;
        }
        public decimal Bonus
        {
            get { return bonus; }
            private set {
                            if (value > 0)
                            {
                                bonus = value; 
                            }else
                            {
                                throw new System.ArgumentOutOfRangeException();
                            }
                        }
        }
        
        public decimal BaseSalary
        {
            get { return baseSalary; }
            private set {
                            if (value > 0)
                            {
                                baseSalary = value; 
                            }
                            else
                            {
                                throw new System.ArgumentOutOfRangeException();
                            }
                        }
        }
        
    }
}