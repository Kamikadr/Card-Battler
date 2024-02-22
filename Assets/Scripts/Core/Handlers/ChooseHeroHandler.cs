using Core.Events;

namespace Core.Handlers
{
    public class ChooseHeroHandler: BaseHandler<ChooseHeroEvent>
    {
        public ChooseHeroHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(ChooseHeroEvent evt)
        {
            //evt.HeroList
        }
    }
}