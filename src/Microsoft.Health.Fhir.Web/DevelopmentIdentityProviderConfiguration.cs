﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.Health.Fhir.Web
{
    public class DevelopmentIdentityProviderConfiguration
    {
        public string Audience { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public IReadOnlyList<DevelopmentIdentityProviderUser> Users { get; set; }
    }
}