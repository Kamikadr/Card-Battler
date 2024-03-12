namespace Core.Handlers
{
    public struct RefreshHeroViewEvent
    {
        public readonly BaseHeroEntity entity;
        public RefreshHeroViewEvent(BaseHeroEntity entity)
        {
            this.entity = entity;
        }
    }
}