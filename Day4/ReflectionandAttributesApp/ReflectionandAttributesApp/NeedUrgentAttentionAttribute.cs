﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionandAttributesApp
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class NeedUrgentAttentionAttribute:Attribute
    {
    }
}
