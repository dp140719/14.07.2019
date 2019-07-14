using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {


            Context ctx = new Context();
            IAmOn on = new IAmOn(ctx);
            ctx.Init(on);

            ctx.pressedOn();
            ctx.pressedOn();
            ctx.pressedOff();
            ctx.pressedOn();
            ctx.pressedOff();
            ctx.pressedOff();
        }
    }
}
