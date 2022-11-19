namespace Herencia
{
    class Herencia
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Jose", 30, "Odontologo");
            Console.WriteLine(doctor1.GetInfo());
            Console.WriteLine(doctor1.GetData());

            Doctor dev1 = new Doctor("Jose", 22, "JS");
            Console.WriteLine(dev1.GetInfo());
            Console.WriteLine(dev1.GetData());

        }

        class People
        {   
            private string _name { get; set; }
            private int _age { get; set; }

            public People(string name, int age)
            {
                _name = name;
                _age = age; 

            }
            public string GetInfo() 
            { 
                { 
                    return _name + " " + _age; 
                } 
            }
            
        }

        class Doctor : People
        {
            private string _speciality;
            public Doctor(string name, int age, string speciality) : base(name, age)
            {
                _speciality = speciality;
            }
            public string GetData()
            {
                return GetInfo() + " " + _speciality;
            }
        }

        class Dev : People
        {
            private string _language;
            public Dev(string name, int age, string language) : base(name, age)
            {
                _language = language;
            }
            public string GetData()
            {
                return GetInfo() + " " + _language;
            }
        }
    }
}
