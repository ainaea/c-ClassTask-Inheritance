namespace InheritanceTask
{
    public abstract class Employee
    {
        public string Name { get; private set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract decimal GetSalary();
    }
}