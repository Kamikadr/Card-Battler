using Core.Components;
using UI;

namespace Core
{
    public sealed class HeroViewComponent: IComponent
    {
        public HeroView Value { get; private set; }

        public HeroViewComponent(HeroView view)
        {
            Value = view;
        }
    }
}