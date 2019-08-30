using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    public class Demo
    {
        private string _name;
        private int _age;
        private string _address;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Demo(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
