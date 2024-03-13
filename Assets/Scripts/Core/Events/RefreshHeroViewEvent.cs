namespace Core.Handlers
{
    public struct RefreshHeroViewEvent: IEvent
    {
        public readonly BaseHeroEntity entity;
        public RefreshHeroViewEvent(BaseHeroEntity entity)
        {
            this.entity = entity;
        }
    }
}