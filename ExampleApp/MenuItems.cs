using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp {
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum MenuItems {
        [Description("Home")]
        Home,
        [Description("Localize Enums")]
        LocalizeEnumsPage
    }
}
