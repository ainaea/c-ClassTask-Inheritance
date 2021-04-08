namespace InheritanceTask
{
    public class Worker : Employee
    {
        private int workHours;
        private decimal hourlyRate;

        public Worker(string name, int hours, decimal rate) : base(name)
        {
            WorkHours = hours;
            HourlyRate = rate;
        }
        public decimal HourlyRate
        {
            get { return hourlyRate; }
            private set {
                if (value > 0)
                {
                    hourlyRate = value; 
                }else
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
        }
        
        public int WorkHours
        {
            get { return workHours; }
            private set {
                    if (value > 0)
                    {
                        workHours = value; 
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
            }
        }

        public override decimal GetSalary()
        {
            return WorkHours * HourlyRate;
        }
        
    }
}