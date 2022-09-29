using System;
using Vintagestory.API;
using Vintagestory.API.Common;

namespace RockSniffer
{
    public class RockSnifferMod : ModSystem
    {
        private ICoreAPI api;

        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            this.api = api;
            this.api.RegisterItemClass("RockSnifferItem", typeof(RockSnifferItem));
        }
    }
}
