using System.Collections.Generic;

namespace Rune_Magic.Spells
{
    public class Spell
    {
        public SpellTargetComponent Target { get; }
        public Queue<SpellEffect> Effects { get; }
        public int Range { get; }

        public Spell(SpellTargetComponent target, Queue<SpellEffect> effects, int range)
        {
            Target = target;
            Effects = effects;
            Range = range;
        }

        public void AddEffect(SpellEffect effect)
        {
            Effects.Enqueue(effect);
        }

        public void Execute()
        {
            foreach (var effect in Effects)
            {
                effect.Apply(Target);
            }
        }
    }
}