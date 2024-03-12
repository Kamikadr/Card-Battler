namespace Core.Events
{
    public struct RefreshHeroEvent
    {
        public readonly BaseHeroEntity entity;

        public RefreshHeroEvent(BaseHeroEntity entity)
        {
            this.entity = entity;
        }
    }
}