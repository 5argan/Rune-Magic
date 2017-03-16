using System.Collections.Generic;
using Nez;

namespace Rune_Magic.Spells
{
    public abstract class SpellEffect
    {
        protected SpellAreaComponent _area;
        public virtual void Apply(SpellTargetComponent target)
        {
        }
    }
}