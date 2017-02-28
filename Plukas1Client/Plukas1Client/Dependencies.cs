﻿using Plukas1Client.Contracts;
using Plukas1Client.Products;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plukas1Client
{
    public class Dependencies
    {
        private Dictionary<string, Type[]> _registeredDependencies;
        public Dictionary<string, Type[]> RegisteredDependencies { get { return _registeredDependencies; } }
        public void InitializeGroups()
        {
            _registeredDependencies.Add("A", new Type[] { typeof(ProductA0) });
        }
    }
}