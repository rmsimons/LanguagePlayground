using System.Collections.Generic;
using System;

namespace WorkflowEngine
{
    class Engine
    {
        private IList<IActivity> _activities;

        public Engine()
        {
            _activities = new List<IActivity>();
        }

        public void Run(Workflow workflow)
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }

        public void RegisterActivity(IActivity activity)
        {
            if (activity == null)
            {
                throw new ArgumentNullException("Not a valid activity.");
            }

            _activities.Add(activity);
        }

    }
}
