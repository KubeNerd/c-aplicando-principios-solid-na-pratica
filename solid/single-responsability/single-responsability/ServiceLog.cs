using System;
using single_responsability.Services;

namespace single_responsability
{
    class ServiceLog: ILogger
    {
        public void Info(string info) 
        {
  
            Console.WriteLine(info);
        }
    }
}
