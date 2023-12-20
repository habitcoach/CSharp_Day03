using System;

namespace _3_indexers
{
    public struct Team

    {
        public Team()
        {

        }

        public string[] departments = new string[] {

        "IT", "Accounts", "Sales", "Management" };

    }


    class Program
    {
        static void Main(string[] args)
        {

            Team team = new Team();

            string firstDepartment = team.departments[0];
            Console.WriteLine(firstDepartment);
        }
    }
}

