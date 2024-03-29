﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T boxValue;

        public T BoxValue { get { return boxValue; } set { boxValue = value; } }

        public Box(T entry)
        {
            boxValue = entry;
        }

        public override string ToString() =>
        $"{this.BoxValue.GetType()}: {this.BoxValue}";
    }
}
