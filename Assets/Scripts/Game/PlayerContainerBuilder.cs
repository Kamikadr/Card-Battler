using System.Collections.Generic;
using Core.DataContainers;
using Game.Heroes;
using UI;
using VContainer.Unity;

namespace Game
{
    public sealed class PlayerContainerBuilder: IInitializable
    {
        private readonly UIService _uiService;
        private readonly PlayerContainer _playerContainer;

        public PlayerContainerBuilder(UIService uiService, PlayerContainer playerContainer)
        {
            _uiService = uiService;
            _playerContainer = playerContainer;
        }

        public void Initialize()
        {
            var enemyEntity = GetHeroEntities(_uiService.GetBluePlayer().GetViews());
            var enemyCharacterContainer = new CharacterEntityContainer(enemyEntity);
            var friendEntity = GetHeroEntities(_uiService.GetRedPlayer().GetViews());
            var friendCharacterContainer = new CharacterEntityContainer(friendEntity);
            
            _playerContainer.SetCharacterContainers(enemyCharacterContainer, friendCharacterContainer);
        }

        private BaseHeroEntity[] GetHeroEntities(IReadOnlyList<HeroView> heroViews)
        {
            var friendEntityArray = new BaseHeroEntity[heroViews.Count];
            for (var i = 0; i < friendEntityArray.Length; i++)
            {
                friendEntityArray[i] = heroViews[i].GetComponent<BaseHeroEntity>();
            }

            return friendEntityArray;
        }
    }
}