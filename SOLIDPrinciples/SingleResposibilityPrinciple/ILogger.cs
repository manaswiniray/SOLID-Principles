﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    interface ILogger
    {
        void LogError(string errorMessage);
    }
}
