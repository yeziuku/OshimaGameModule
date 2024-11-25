﻿using Milimoe.FunGame.Core.Entity;
using Milimoe.FunGame.Core.Library.Constant;
using Oshima.FunGame.OshimaModules.Effects.SkillEffects;

namespace Oshima.FunGame.OshimaModules.Skills
{
    public class 反魔法领域 : Skill
    {
        public override long Id => (long)MagicID.反魔法领域;
        public override string Name => "反魔法领域";
        public override string Description => Effects.Count > 0 ? string.Join("\r\n", Effects.Select(e => e.Description)) : "";
        public override double MPCost => Level > 0 ? 85 + (80 * (Level - 1)) : 85;
        public override double CD => Level > 0 ? 90 - (2 * (Level - 1)) : 75;
        public override double CastTime => Level > 0 ? 15 + (1 * (Level - 1)) : 15;
        public override double HardnessTime { get; set; } = 10;
        public override int CanSelectTargetCount { get; set; } = 6;

        public 反魔法领域(Character? character = null) : base(SkillType.Magic, character)
        {
            Effects.Add(new 造成封技(this, true, 15, 0));
        }
    }
}
