﻿// <copyright file="CacheManagerConfiguration.cs" company="Okta, Inc">
// Copyright (c) 2014-2017 Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Sdk.Abstractions
{
    public sealed class CacheManagerConfiguration
    {
        public bool? Enabled { get; set; } = true;

        public int? DefaultTtl { get; set; } = 300; // Seconds

        public int? DefaultTti { get; set; } = 300; // Seconds

        // TODO - Caches
    }
}
