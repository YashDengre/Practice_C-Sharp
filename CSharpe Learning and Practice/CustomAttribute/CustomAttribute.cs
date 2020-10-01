using System;

namespace CSharpe_Learning_and_Practice.CustomAttribute
{
    //Attributes are very useful with Reflection
    //You can perform run time operations to validate, manipulate or to do any extra work which is requried.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate | AttributeTargets.Method, AllowMultiple = true)]
    public class CustomAttributeDebugInfo : Attribute
    {

        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public CustomAttributeDebugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }
        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }

}
