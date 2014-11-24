using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Infrastructure
{
    public interface IMetrics
    {
        void Timing(string keyName, TimeSpan timeSpan);
    }

    public class Metrics : IMetrics
    {
        public void Timing(string keyName, TimeSpan timeSpan)
        {
            var msg = String.Format("{0} {1}ms", keyName, timeSpan.Milliseconds);
            Console.WriteLine(msg);
        }
    }
}
