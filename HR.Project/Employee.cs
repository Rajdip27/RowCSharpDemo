namespace HR.Project;

public class Employee:Person
{
    public Employee()
    {
        
    }

    public Employee(double basic, double pf, double ta, double hr)
    {
        HR = hr;
        PF = pf;
        Basic = basic;
        TA = ta;
    }
    public string Designation { get; set; }
    public string Department { get; set; }
    private double HR { get; set; }
    private double PF { get; set; }
    private double TA { get; set; }
    private double Basic { get; set; }

    public double Salary()
    {
        return HR- PF + Basic + TA;
    }
}
