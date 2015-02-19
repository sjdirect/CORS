﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Cors;

namespace Microsoft.AspNet.Builder
{
    public static class CorsExtensions
    {
        /// <summary>
        /// Adds a CORS middleware to your web application pipeline to allow cross domain requests.
        /// </summary>
        /// <param name="app">The IApplicationBuilder passed to your Configure method</param>
        /// <param name="options">An options class that controls the middleware behavior</param>
        /// <returns>The original app parameter</returns>
        public static IApplicationBuilder UseCors([NotNull]this IApplicationBuilder app, [NotNull]CorsOptions options)
        {
            return app.UseMiddleware<CorsMiddleware>(options);
        }
    }
}