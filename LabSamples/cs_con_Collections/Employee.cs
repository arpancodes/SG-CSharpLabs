namespace cs_con_Collections.Demo
{
    class Employee
    {
        public int Id { get; set; }

        // public string? EmployeeName { get; set; }
        public string EmployeeName { get; set;  }

        public short Age { get; set; }

        public Employee()
        {
            this.EmployeeName = string.Empty;
        }
    }
}

