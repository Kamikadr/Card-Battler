namespace Core.Events
{
    public struct RefreshHeroEvent: IEvent
    {
        public readonly BaseHeroEntity entity;

        public RefreshHeroEvent(BaseHeroEntity entity)
        {
            this.entity = entity;
        }
    }
}