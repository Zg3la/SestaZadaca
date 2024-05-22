using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca6
{
    public abstract class Handler
    {
        public Handler NextHandler;

        public void SetNextHandler(Handler NextHandler)
        {
            this.NextHandler = NextHandler;
        }
        public abstract void DispatchNote(long requestedAmount);
    }
}
