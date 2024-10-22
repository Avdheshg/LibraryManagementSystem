using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Member
    {
        public string Name { get; set; }

        public Member(string name)
        {
            Name = name;
        }

        public void DisplayMemberInfo()
        {
            Console.WriteLine($"Member: {Name}");
        }

    }
}
