﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandGatherers.Framework
{
    public class ModConfig
    {
        public bool DoParrotsEatExcessCrops { get; set; }
        public bool DoParrotsHarvestFromPots { get; set; }
        public bool DoParrotsAppearAfterHarvest { get; set; }
        public bool DoParrotsHarvestFromFruitTrees { get; set; }
        public bool DoParrotsHarvestFromFlowers { get; set; }
        public bool DoParrotsSowSeedsAfterHarvest { get; set; }
        public bool EnableHarvestMessage { get; set; }
        public int MinimumFruitOnTreeBeforeHarvest { get; set; }

        public ModConfig()
        {
            DoParrotsEatExcessCrops = true;
            DoParrotsHarvestFromPots = true;
            DoParrotsAppearAfterHarvest = true;
            DoParrotsHarvestFromFruitTrees = true;
            DoParrotsHarvestFromFlowers = true;
            DoParrotsSowSeedsAfterHarvest = true;

            EnableHarvestMessage = true;

            MinimumFruitOnTreeBeforeHarvest = 3;
        }
    }
}
