

using MyLibrary;

Employee Nicol = new Secretary();
Nicol.Name = "Nicol";
Employee Juan = new Manager();
Juan.Name = "Juan";
Developer Vanessa = new Developer();
Console.WriteLine($"Dias: {Vanessa.GetPaymentDays()}");

WriteEmployeeInfo(Nicol);
WriteEmployeeInfo(Juan);
WriteEmployeeInfo(Vanessa);

void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine($"{employee.Name} : {employee.CalculateMonthlpayment()}");
    Console.WriteLine($" Days: {employee.GetPaymentDays()}");
}