﻿// <copyright file="AwesomeInventoryBodyPartGroupDefOf.cs" company="Zizhen Li">
// Copyright (c) 2019 - 2020 Zizhen Li. All rights reserved.
// Licensed under the LGPL-3.0-only license. See LICENSE.md file in the project root for full license information.
// </copyright>

using RimWorld;
using Verse;

namespace AwesomeInventory
{
    [DefOf]
    public static class AwesomeInventoryBodyPartDefOf
    {
        public static BodyPartDef Neck;

        static AwesomeInventoryBodyPartDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(AwesomeInventoryBodyPartDefOf));
        }
    }
}