// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Relational.Migrations.Infrastructure
{
    public abstract class ModelSnapshot
    {
        public abstract void BuildModel([NotNull] ModelBuilder modelBuilder);
    }
}
