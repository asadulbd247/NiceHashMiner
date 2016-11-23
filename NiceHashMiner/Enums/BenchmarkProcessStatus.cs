﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashMiner.Enums {
    public enum BenchmarkProcessStatus {
        NONE,
        Idle,
        Running,
        Killing,
        DoneKilling,
        Finished,
        Success
    }
}
