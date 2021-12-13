﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Settings
{
    public class ApplicationSettings
    {
        public ApplicationSettings() => this.Secret = default!;

        public string Secret { get; private set; }
    }
}
