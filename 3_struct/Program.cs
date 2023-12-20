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

        public string this[int index] {

            get { return this.departments[index]; }

            set { this.departments[index] = value; }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Team team = new Team();

            string firstDepartment = team.departments[0]; // without using indexer
          
            Console.WriteLine(firstDepartment);

            Console.WriteLine(team[0]); // with indexer. Make code more cleaner and secure
        }
    }
}

