using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp.Modules.LocalizeEnums {
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status {
        [Description("This is horrible")]
        Horrible,
        [Description("This is bad")]
        Bad,
        [Description("This is so so")]
        SoSo,
        [LocalizedDescription("Good", typeof(Resources.EnumResources))] 
        Good,
        [LocalizedDescription("Better", typeof(Resources.EnumResources))]
        Better,
        [LocalizedDescription("Best", typeof(Resources.EnumResources))]
        Best
    }
}
