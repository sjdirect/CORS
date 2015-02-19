﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Cors.Core
{
    /// <inheritdoc />
    public class CorsPolicyProvider : ICorsPolicyProvider
    {
        /// <summary>
        /// Creates a new CorsPolicyProvider instance.
        /// </summary>
        public CorsPolicyProvider()
        {
            PolicyResolver = request => Task.FromResult<ICorsPolicy>(null);
        }

        /// <summary>
        /// A pluggable callback that will be used to select the CORS policy for the given requests.
        /// </summary>
        public Func<ICorsRequestContext, Task<ICorsPolicy>> PolicyResolver { get; set; }

        /// <inheritdoc />
        public virtual Task<ICorsPolicy> GetCorsPolicyAsync(ICorsRequestContext context)
        {
            return PolicyResolver(context);
        }
    }
}