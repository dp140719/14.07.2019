using System;

namespace State
{
    public class IAmOff : StateBase
    {
        public IAmOff(Context ctx) : base(ctx)
        {
        }

        public override void TurnOff()
        {
            Console.WriteLine("Light is already off...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Turning on the light!");
            ctx.State = new IAmOff(ctx); 
        }
    }
}
