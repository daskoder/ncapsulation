using Endcapsulation.Service;

namespace ncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kapseldamine");

            Student student = new Student();

            student.Id = 101;
            student.Name = "Test";
            student.Email = "Test@test.com";

            Console.WriteLine("id = "+student.Id);
            Console.WriteLine("Name = "+student.Name);
            Console.WriteLine("Email = "+student.Email);

            //kasutame protected klassi
            ProtectedStudent protectedStudent = new ProtectedStudent();
            //protectedStudent.dosmth();
            //kui dosmth on protected ja teises classis, siis ei saa kasutada

            Console.WriteLine("--------------------");
            Program program= new Program();
            program.dosmthinprogclass();
            Console.WriteLine("--------------------");
            Program pp = new Program();
            Console.WriteLine(pp.privateProtectedinPROGRAMCLASS = "privateProtectedinPROGRAMCLASSMainMethod");
            //ei saa kasutada kuna on private
            var privateProtectedStudent = new PrivateProtctedStudent();
            //alumine annab errorit
            //privateProtectedStudent.PrivateProtctedStudent1 = "asdasd";
            Console.WriteLine("------------Sealed Class------------");
            //Sealed classi kasutamine
            var sc = new SealedStudent();
            sc.Id = 123;
            sc.name = "Test";
            sc.Email = "Test@Test.com";
            Console.WriteLine($"Id on {sc.Id}, Name on {sc.name}, Email on {sc.Email}");
        }
        protected void dosmthinprogclass()
        {
            Console.WriteLine("dosmthinprogclass");
        }

        private protected string privateProtectedinPROGRAMCLASS = "privateProtectedinPROGRAMCLASS";


    }

}
