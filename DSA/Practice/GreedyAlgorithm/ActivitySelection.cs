using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice.GreedyAlgorithm
{
    internal class ActivitySelection
    {
        internal List<Activity> SelectActivities(List<Activity> activities)
        {
            var selectedActivities = new List<Activity>();
            var sortedList = activities.OrderBy(x => x.End).ToList();
            var previousActivity = sortedList.First();
            selectedActivities.Add(previousActivity);

            for(int i = 1; i < sortedList.Count; i++)
            {
                if(sortedList[i].Start > previousActivity.End)
                {
                    previousActivity = sortedList[i];
                    selectedActivities.Add(sortedList[i]);
                }
            }

            return selectedActivities;
        }
    }

    internal class Activity
    {
        public int Start;
        public int End;
    }


}
