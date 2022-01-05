using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOFresponseability_example
{
    abstract class handler
    {
        protected handler successor;
        public void setsuccessor(handler successor)
        {
            this.successor = successor;
        }
        public abstract void handlerRequest(int rqs);
        internal abstract void setsuccessor(int rqs);
    }

    //Does not recognize subclasses
  internal class Concretehanler_one : handler
    {

        public override void handlerRequest(int rqs)
        {
            if (rqs >= 0 && rqs < 10)
            {
                Console.WriteLine("[0] request by [1]", this.GetType().Name, rqs);
            }
            else if (successor != null)
            {
                successor.handlerRequest(rqs);
            }
        }

        internal override void setsuccessor(int rqs)
        {
            if (rqs >= 1 && rqs < 10)
            {
                Console.WriteLine("[0] request by [1]", this.GetType().Name, rqs);
            }
            else if (successor != null)
            {
                successor.handlerRequest(rqs);
            }
        }
    }

   internal  class Concretehanler_tow : handler
    {
        public override void handlerRequest(int rqs)
        {
            if (rqs >= 5 && rqs < 10)
            {
                Console.WriteLine("[0] request by [1]", this.GetType().Name, rqs);
            }
            else if (successor != null)
            {
                successor.handlerRequest(rqs);
            }
        }

        internal override void setsuccessor(int rqs)
        {
            if (rqs >= 20 && rqs < 10)
            {
                Console.WriteLine("[0] request by [1]", this.GetType().Name, rqs);
            }
            else if (successor != null)
            {
                successor.handlerRequest(rqs);
            }
        }
    }

    internal class Concretehanler_three : handler
    {
        public override void handlerRequest(int rqs)
        {
            if (rqs >= 20 && rqs < 10)
            {
                Console.WriteLine("[0] request by [1]", this.GetType().Name, rqs);
            }
            else if (successor != null)
            {
                successor.handlerRequest(rqs);
            }
        }

        internal override void setsuccessor(int rqs)
        {
            if (rqs >= 20 && rqs < 10)
            {
                Console.WriteLine("[0] request by [1]", this.GetType().Name, rqs);
            }
            else if (successor != null)
            {
                successor.handlerRequest(rqs);
            }
        }
    }
}
