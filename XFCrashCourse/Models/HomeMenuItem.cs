using System;
using System.Collections.Generic;
using System.Text;

namespace XFCrashCourse.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Label,
        Button
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
