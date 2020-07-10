﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.DependencyInjection;

namespace Steeltoe.Discovery.Client
{
    public interface IDiscoveryClientExtension
    {
        /// <summary>
        /// Implementations of this method will add services required by the <see cref="IDiscoveryClient"/> to the service collection for activation later
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/> to configure</param>
        void ApplyServices(IServiceCollection services);
    }
}