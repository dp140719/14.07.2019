using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class StateBase : ILightState
    {

        protected Context ctx;

        protected StateBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void TurnOff();

        public abstract void TurnOn();


    }
}
