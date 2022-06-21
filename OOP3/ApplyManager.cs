using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplyManager
    {
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (ILoggerService loggerService in loggerServices)
                loggerService.Log();
        }
        public void PreInformUser(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
                credit.Calculate();
        }
    }
}
