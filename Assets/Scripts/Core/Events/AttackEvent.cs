﻿using UI;

namespace Core.Events
{
    public struct AttackEvent
    {
        public IHeroListenable Target;
        public IHeroListenable Source;

        public AttackEvent(IHeroListenable source, IHeroListenable target)
        {
            Target = target;
            Source = source;
        }
    }
}