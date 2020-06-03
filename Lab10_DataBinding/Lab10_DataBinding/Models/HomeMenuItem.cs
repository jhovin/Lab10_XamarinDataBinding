using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_DataBinding.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        ViewDemo,
        BindingMode,
        ListBinding,
        PickerBinding,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
