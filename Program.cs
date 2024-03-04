namespace rough2
{

    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Employee(int age, string name, string address)
        {
            Age = age;
            Name = name;
            Address = address;
        }

        public static List<Employee> Employees = new List<Employee>();

        public static void AddEmployee(Employee e)
        {
            Employees.Add(e);
            Console.WriteLine("Employee details added successfully.\n");
        }

        public static void UpdateEmployee(Employee e)
        {
            Console.WriteLine("Enter name to update:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age to update:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter address to update:");
            string address = Console.ReadLine();

            e.Name = name;
            e.Age = age;
            e.Address = address;
            Console.WriteLine("Employee details updated successfully.\n");
        }
      
        public static void DeleteEmployee(string name)
        {
            var emp = Employees.Find(e => e.Name == name);
            if (emp != null)
            {
                Employees.Remove(emp);
                Console.WriteLine("Employee deleted successfully.\n");
            }
            else
            {
                Console.WriteLine("Employee not found.\n");
            }
        }

        public static void DisplayEmployees()
        {
            Console.WriteLine("Employee Details:");
            foreach (var emp in Employees)
            {
                Console.WriteLine("Name: " + emp.Name);
                Console.WriteLine("Age: " + emp.Age);
                Console.WriteLine("Address: " + emp.Address);
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose your option..\n1. Add employee details\n2. Update employee details\n3. Delete employee\n4. Display employee details\n5. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter age:");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter address:");
                        string address = Console.ReadLine();
                        Employee.AddEmployee(new Employee(age, name, address));
                      
                        break;
                    case 2:
                        Console.WriteLine("Enter name of employee to update:");
                        string empNameToUpdate = Console.ReadLine();
                        Employee.UpdateEmployee(Employee.Employees.Find(e => e.Name == empNameToUpdate));
                        break;
                    case 3:
                        Console.WriteLine("Enter name of employee to delete:");
                        string empNameToDelete = Console.ReadLine();
                        Employee.DeleteEmployee(empNameToDelete);
                        break;
                    case 4:
                        Employee.DisplayEmployees();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }
    }
    
 }

    
























    /*int first = array[0];
    int second = int.MinValue;
    int third= int.MinValue;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > first)
        {
            third = second;
            second = first;
            first = array[i];
        }
        else if (array[i] > second)
        {
            third = second;
            second = array[i];
        }
        else if (array[i] > third)
        {
            third = array[i];
        }
    }*/














    



