﻿using System;
using System.Collections.Generic;

namespace Drill19
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();
    }
}
