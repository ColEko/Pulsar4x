﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Pulsar4X.Entities
{
    public class StarSystem
    {
        public ObservableCollection<Star> Stars { get; set; }
    }
}