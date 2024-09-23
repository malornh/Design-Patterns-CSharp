using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    public class SlackServiceDecorator : INotifierService
    {
        private readonly INotifierService _notifierService;

        public SlackServiceDecorator(INotifierService notifierService)
        {
            _notifierService = notifierService;
        }

        public void Notify(string user)
        {
            _notifierService.Notify(user);
            Console.WriteLine("Sent Slack notification to the " + user + ".");
        }
    }
}
