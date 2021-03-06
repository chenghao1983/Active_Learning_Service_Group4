﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Web;
using ActiveLearning.Common;
using ActiveLearning.Business.Implementation;
using System.IO;

namespace ActiveLearning.WF.Activity
{

    public sealed class CheckIfFileExists : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<Byte[]> FileBytes { get; set; }
        public InArgument<string> FileName { get; set; }
        public OutArgument<bool> IfFileExists { get; set; }
        public OutArgument<string> Message { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            Byte[] fileBytes = context.GetValue(this.FileBytes);
            string fileName = context.GetValue(this.FileName);

            bool ifFileExists = true;
            string message = string.Empty;

            if (fileBytes == null || fileBytes.Length == 0 || string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName.Trim()))
            {
                ifFileExists = false;
                message = Constants.ValueIsEmpty(Constants.File);
            }

            context.SetValue(this.IfFileExists, ifFileExists);
            context.SetValue(this.Message, message);
        }
    }
}
