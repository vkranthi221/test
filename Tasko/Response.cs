﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using TaskoCore;

namespace Tasko
{
    [DataContract]
    [KnownType(typeof(User))]
    [KnownType(typeof(Order))]
    public class Response
    {
        [DataMember]
        public bool Error { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public int Status { get; set; }

        [DataMember]
        public object Data { get; set; }
    }
}