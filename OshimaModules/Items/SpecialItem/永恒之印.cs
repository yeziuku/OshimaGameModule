﻿using Milimoe.FunGame.Core.Entity;
using Milimoe.FunGame.Core.Library.Constant;

namespace Oshima.FunGame.OshimaModules.Items
{
    public class 永恒之印() : Item(ItemType.SpecialItem)
    {
        public override long Id => (long)SpecialItemID.永恒之印;
        public override string Name => "永恒之印";
        public override string Description => "角色突破等阶必备的高级材料。";
        public override QualityType QualityType => QualityType.Blue;
    }
}
