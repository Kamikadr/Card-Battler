using Core.Effects.EndTurnGeneral;
using UnityEngine;

namespace Core.Heroes
{
    public class MeditatorEntity: BaseHeroEntity
    {
        [SerializeField] private int healValue;
        protected override void OnInitialize()
        {
            AddEffect<EndTurnGeneralEffect>(new EndTurnRandomHealEffect(healValue, this));
        }
    }
}