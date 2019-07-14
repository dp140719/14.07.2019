using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmOn : StateBase
    {
        public IAmOn(Context ctx) : base(ctx)
        {
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turning off the light....");
            ctx.State = new IAmOn(ctx);
        }

        public override void TurnOn()
        {
            Console.WriteLine("already on...");
        }
    }
}
