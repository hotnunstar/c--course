﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomTaskAssignmentManager customTaskManager = new CustomTaskAssignmentManager();
            customTaskManager.AssignTask("Complete project report");
        }
    }
}
