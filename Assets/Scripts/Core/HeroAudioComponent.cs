using Core.Components;
using UnityEngine;

namespace Core
{
    public class HeroAudioComponent: IComponent
    {
        private readonly AudioClip[] _startAudioClips;
        private readonly AudioClip[] _lowHealthAudioClip;
        private readonly AudioClip[] _abilityAudioClip;
        private readonly AudioClip[] _deathAudioClip;

        public HeroAudioComponent(
            AudioClip[] startAudioClips,
            AudioClip[] lowHealthAudioClip,
            AudioClip[] abilityAudioClip,
            AudioClip[] deathAudioClip)
        {
            _startAudioClips = startAudioClips;
            _lowHealthAudioClip = lowHealthAudioClip;
            _abilityAudioClip = abilityAudioClip;
            _deathAudioClip = deathAudioClip;
        }

        public AudioClip GetStartAudio()
        {
            return _startAudioClips[GetRandomNumber( _startAudioClips.Length - 1)];
        }
        public AudioClip GetLowHealthAudio()
        {
            return _lowHealthAudioClip[GetRandomNumber( _lowHealthAudioClip.Length - 1)];
        }
        public AudioClip GetAbilityAudio()
        {
            return _abilityAudioClip[GetRandomNumber( _abilityAudioClip.Length - 1)];
        }
        public AudioClip GetDeathAudio()
        {
            return _deathAudioClip[GetRandomNumber( _deathAudioClip.Length - 1)];
        }


        private int GetRandomNumber(int max)
        {
            return  Random.Range(0, max);
        }
    }
}