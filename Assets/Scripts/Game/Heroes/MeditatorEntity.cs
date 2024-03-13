using Core.Effects.EndTurnGeneral;
using UnityEngine;

namespace Game.Heroes
{
    public sealed class MeditatorEntity: BaseHeroEntity
    {
        [SerializeField] private int healValue;
        protected override void OnInitialize()
        {
            AddEffect<EndTurnGeneralEffect>(new EndTurnRandomHealEffect(healValue, this));
        }
    }
}