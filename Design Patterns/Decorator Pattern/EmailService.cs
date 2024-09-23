using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    public class EmailService : INotifierService
    {
        public void Notify(string user)
        {
            Console.WriteLine("Sent email to the " + user + ".");
        }
    }
}
