using System;
using System.Collections.Generic;
using System.Text;

namespace XFCrashCourse.Models
{
    public enum MenuItemType
    {
        Home,
        About,
        Label,
        Button,
        SignUp
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
