﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Data.Entity.Relational.Query.Methods;

namespace Microsoft.Data.Entity.SqlServer.Query.Methods
{
    public class MathFloorTranslator : MultipleOverloadStaticMethodCallTranslator
    {
        public MathFloorTranslator()
            : base(typeof(Math), "Floor", "FLOOR")
        {
        }
    }
}
