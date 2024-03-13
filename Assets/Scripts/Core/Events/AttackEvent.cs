using Core.DataContainers;

namespace Core.Events
{
    public struct AttackEvent: IEvent
    {
        public readonly IHeroListenable Target;
        public readonly IHeroListenable Source;

        public AttackEvent(IHeroListenable source, IHeroListenable target)
        {
            Target = target;
            Source = source;
        }
    }
}