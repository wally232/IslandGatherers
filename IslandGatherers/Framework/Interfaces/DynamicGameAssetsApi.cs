﻿using StardewModdingAPI;
using System;
using System.Collections.Generic;

namespace IslandGatherers.Framework.Interfaces
{
    public interface DynamicGameAssetsApi
    {
        /// <summary>
        /// Get the DGA item ID of this item, if it has one.
        /// </summary>
        /// <param name="item">The item to get the DGA item ID of.</param>
        /// <returns>The DGA item ID if it has one, otherwise null.</returns>
        string GetDGAItemId(object item);
        object SpawnDGAItem(string fullId);
        void AddEmbeddedPack(IManifest manifest, string dir);
    }
}
