
using System;

namespace PlayingWithStructureAndClass
{
    struct Employee
    {
        public int EmpID { get; private set; }

        public Employee(int id)
        {
            EmpID = id;
        }

        public int IncrementEmpID()
        {
            EmpID++;
            return EmpID;
        }
    }

    class Program
    {
        public Employee PropEmployee { get; } = new Employee(10);
        public readonly Employee ReadonlyEmployee = new Employee(10);
        public Employee FieldMemberEmployee = new Employee(10);

        public void Test()
        {
            Console.WriteLine("===========Property case=============");
            Console.WriteLine(PropEmployee.IncrementEmpID());
            Console.WriteLine(PropEmployee.IncrementEmpID());

            Console.WriteLine("===========Readonly case=============");
            Console.WriteLine(ReadonlyEmployee.IncrementEmpID());
            Console.WriteLine(ReadonlyEmployee.IncrementEmpID());

            Console.WriteLine("===========Field Member case==========");
            Console.WriteLine(FieldMemberEmployee.IncrementEmpID());
            Console.WriteLine(FieldMemberEmployee.IncrementEmpID());
        }

        static void Main(string[] args)
        {

            new Program().Test();
        }
    }
}

