﻿using System;
using System.Collections.Generic;

namespace SpecAidTests.Vaporware
{
    public class EveryThingObject
    {
        public Guid AGuid { get; set; }
        public Guid? ANullableGuid { get; set; }
        public int AnInt { get; set; }
        public IList<string> ListStrings { get; set; }
        public IEnumerable<string> SomeStrings { get; set; }
        public EveryThingObject InnerEveryThingObject { get; set; }
    }
}