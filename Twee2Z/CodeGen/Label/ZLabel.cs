﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twee2Z.CodeGen.Address;

namespace Twee2Z.CodeGen.Label
{
    class ZLabel : ZComponent
    {
        protected ZAddress _targetAddress = null;
        protected string _name;

        public ZLabel(ZAddress address)
        {
            _targetAddress = address;
        }

        public ZLabel(string name)
        {
            _name = name;
        }

        public ZLabel(ZAddress address, string name)
            : this(name)
        {
            _targetAddress = address;
        }

        public ZAddress TargetAddress
        {
            get
            {
                return _targetAddress;
            }
            set
            {
                _targetAddress = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override byte[] ToBytes()
        {
            throw new Exception("Cannot convert a abstract ZLabel into Z-Code.");
        }

        public override int Size
        {
            get
            {
                return ZAddress.Size;
            }
        }
    }
}
