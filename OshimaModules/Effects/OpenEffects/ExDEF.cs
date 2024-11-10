﻿using Milimoe.FunGame.Core.Entity;
using Milimoe.FunGame.Core.Library.Constant;

namespace Oshima.FunGame.OshimaModules.Effects.OpenEffects
{
    public class ExDEF : Effect
    {
        public override long Id => (long)EffectID.ExDEF;
        public override string Name => "物理护甲加成";
        public override string Description => $"{(实际加成 >= 0 ? "增加" : "减少")}角色 {Math.Abs(实际加成):0.##} 点物理护甲。" + (Source != null && Skill.Character != Source ? $"来自：[ {Source} ]" + (Skill.Item != null ? $" 的 [ {Skill.Item.Name} ]" : "") : "");
        public override EffectType EffectType => EffectType.Item;
        
        private readonly double 实际加成 = 0;

        public override void OnEffectGained(Character character)
        {
            character.ExDEF2 += 实际加成;
        }

        public override void OnEffectLost(Character character)
        {
            character.ExDEF2 -= 实际加成;
        }

        public ExDEF(Skill skill, Dictionary<string, object> args, Character? source = null) : base(skill, args)
        {
            GamingQueue = skill.GamingQueue;
            Source = source;
            if (Values.Count > 0)
            {
                string key = Values.Keys.FirstOrDefault(s => s.Equals("exdef", StringComparison.CurrentCultureIgnoreCase)) ?? "";
                if (key.Length > 0 && double.TryParse(Values[key].ToString(), out double exDEF))
                {
                    实际加成 = exDEF;
                }
            }
        }
    }
}
