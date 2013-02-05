using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FellowshipOne.API.Giving.Enum {
    public enum BatchStatus {
        NotApplicable = 0,
        DataEntry = 1,
        Authorization = 2,
        Settlement = 3,
        Pending = 4,
        Saved = 5,
        InProgress = 6
    }
}
