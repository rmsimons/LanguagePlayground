using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            engine.RegisterActivity(new FooActivity());
            engine.RegisterActivity(new BarActivity());
            engine.Run(new Workflow());
        }
    }
}
