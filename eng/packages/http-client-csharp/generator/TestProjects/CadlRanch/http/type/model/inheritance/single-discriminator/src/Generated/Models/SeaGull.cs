// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Type.Model.Inheritance.SingleDiscriminator.Models
{
    public partial class SeaGull : Bird
    {
        public SeaGull(int wingspan) : base("seagull", wingspan) => throw null;

        internal SeaGull(string kind, int wingspan, IDictionary<string, BinaryData> additionalBinaryDataProperties) : base(kind, wingspan, additionalBinaryDataProperties) => throw null;
    }
}
