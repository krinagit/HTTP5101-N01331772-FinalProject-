using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTP_5101_Finalproject
{
    //REFERENCE: I am taking this code as a reference from inclass example taught by Christine during the lectures for the finalproject
    public class HTTP_Page
    {
        private String pageTitle;
        private String pageBody;

        public string GetPageTitle()
        {
            return pageTitle;
        }
        public string GetPageBody()
        {
            return pageBody;
        }
        public void SetPageTitle(string value)
        {
            pageTitle = value;
        }

        public void SetPageBody(string value)
        {
            pageBody= value;
        }
    }

}