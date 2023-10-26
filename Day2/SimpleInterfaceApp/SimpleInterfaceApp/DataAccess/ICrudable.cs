﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    internal interface ICrudable
    {
        void Create();
        void Read();

        void Update();
        void Delete();
    }
}
