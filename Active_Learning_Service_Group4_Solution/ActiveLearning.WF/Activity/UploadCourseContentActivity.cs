﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace ActiveLearning.WF.Activity
{

    public sealed class UploadCourseContentActivity : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> PhysicalUploadPath { get; set; }
        public InArgument<int> CourseSid { get; set; }


        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string physicalUploadPath = context.GetValue(this.PhysicalUploadPath);

            int courseSid = context.GetValue(this.CourseSid);





        }
    }
}
