using UI;

namespace Core.Events
{
    public struct AttackEvent: IEvent
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