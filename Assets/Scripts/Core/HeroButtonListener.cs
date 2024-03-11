using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Core
{
    public sealed class HeroButtonListener: IDisposable
    {
        private readonly IEnumerable<HeroListView> _heroes;
        private readonly Dictionary<HeroView, HeroEntity> _heroMap;
        public event Action<HeroEntity> OnEntityClick;

        public HeroButtonListener(IEnumerable<HeroListView> heroes)
        {
            _heroes = heroes;
            _heroMap = new Dictionary<HeroView, HeroEntity>();

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