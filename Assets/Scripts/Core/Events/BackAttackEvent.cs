using Core.DataContainers;

namespace Core.Events
{
    public struct BackAttackEvent: IEvent
    {
        public readonly IHeroListenable Target;
        public readonly IHeroListenable Source;

        public BackAttackEvent(IHeroListenable source, IHeroListenable target)
        {
            Target = target;
            Source = source;
        }
    }
}