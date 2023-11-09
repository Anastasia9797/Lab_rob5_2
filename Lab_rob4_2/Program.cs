//інтерфейс IParent, що описує отримання співробітниками зарплати і премії 
interface IParent
{
    string Info(); //інформацію про поля об'єкта
    void Metod1(); //обчислює розмір зарплати
    void Metod2(); //обчислює розмір премії
}
// клас Child1, що описує співробітника, що працює на ставці
class Child1 : IParent
{
    double pole1; //зарплата
    double pole2; //премія
    public Child1(double salary)
    {
        pole1 = salary;
    }
    public string Info()
    {
        return $"На ставцi: зарплата = {pole1}, премiя = {pole2}";
    }
    public void Metod1()
    {
        pole1 = pole1;
    }
    public void Metod2()
    {
        pole2 = 0.25 * pole1;
    }
}
// клас Child2, що описує службовця, що одержує погодинну зарплату
class Child2 : IParent
{
    double pole1; //зарплата
    double pole2; //премія
    int pole3; //кількість годин
    double pole4; //вартість однієї години
    public Child2(int hours, double hour1)
    {
        pole3 = hours;
        pole4 = hour1;
    }
    public string Info()
    {
        return $"Погодинник: кiлькiсть годин = {pole3}, вартiсть години = {pole4}, зарплата = {pole1}, премiя = {pole2}";
    }
    public void Metod1()
    {
        pole1 = pole3 * pole4;
    }
    public void Metod2()
    {
        pole2 = 2000;
    }
}
// клас Child3, що описує службовця, що одержує відсоток від суми продажів
class Child3 : IParent
{
    double pole1; //зарплата
    double pole2; //премія
    double pole5; //сума продажу
    public Child3(double sumapr)
    {
        pole5 = sumapr;
    }
    public string Info()
    {
        return $"На вiдсотку: сума продажiв = {pole5}, зарплата = {pole1}, премiя = {pole2}";
    }
    public void Metod1()
    {
        pole1 = Math.Round(0.1 * pole5, 2);
    }
    public void Metod2()
    {
        pole2 = Math.Round(0.2 * pole1, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var o = new Random();
        for (int i = 0; i < 5; i++)
        {
            int type = o.Next(1, 4);
            if (type == 1)
            {
                double salary = o.Next(9000, 25000);
                Child1 employee = new Child1(salary);
                employee.Metod1();
                employee.Metod2();
                Console.WriteLine(employee.Info());
            }
            else if (type == 2)
            {
                int hours = o.Next(30, 61);
                double hour1 = o.Next(150, 600);
                Child2 employee = new Child2(hours, hour1);
                employee.Metod1();
                employee.Metod2();
                Console.WriteLine(employee.Info());
            }
            else
            {
                double sumapr = o.Next(100000, 500000);
                Child3 employee = new Child3(sumapr);
                employee.Metod1();
                employee.Metod2();
                Console.WriteLine(employee.Info());
            }
        }
    }
}