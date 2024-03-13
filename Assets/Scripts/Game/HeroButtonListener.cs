using System;
using System.Collections.Generic;
using Core;
using UI;

namespace Game
{
    public sealed class HeroButtonListener: IDisposable
    {
        private readonly List<HeroListView> _heroes = new();
        private readonly Dictionary<HeroView, HeroEntity> _heroMap = new();
        public event Action<HeroEntity> OnEntityClick;

        public HeroButtonListener(UIService uiService)
        {
            _heroes.Add(uiService.GetBluePlayer());
            _heroes.Add(uiService.GetRedPlayer());

            foreach (var hero in _heroes)
            {
                var views = hero.GetViews();
                foreach (var view in views)
                {
                    var entity = view.GetComponent<HeroEntity>();
                    _heroMap.Add(view, entity);
                }

                hero.OnHeroClicked += OnOnEntityClick;
            }
        }

        private void OnOnEntityClick(HeroView view)
        {
            OnEntityClick?.Invoke(_heroMap[view]);
        }

        public void Dispose()
        {
            foreach (var hero in _heroes)
            {
                hero.OnHeroClicked -= OnOnEntityClick;
            }
            _heroMap.Clear();
        }
    }
}