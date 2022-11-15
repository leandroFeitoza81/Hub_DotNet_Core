namespace FirstWebAppMVC.Models;

public static class Repository
{
    private static List<Employee> allEmployees = new List<Employee>();

    public static IEnumerable<Employee> AllEmployees => allEmployees;

    public static void Create(Employee employee)
    {
        allEmployees.Add(employee);
    }
}
