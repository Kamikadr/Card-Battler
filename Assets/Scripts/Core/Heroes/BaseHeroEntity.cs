﻿using System;
using Core.Components;
using Core.Effects;
using Core.Handlers;
using UI;
using UnityEngine;

namespace Core
{
    [RequireComponent(typeof(HeroView))]
    public abstract  class BaseHeroEntity: HeroEntity
    {
        [SerializeField] private int baseHealth;
        [SerializeField] private int baseDamage;
        [SerializeField] private Team team;
        
        [Header("Audio")]
        [SerializeField] private  AudioClip[] startAudioClips;
        [SerializeField] private AudioClip[] lowHealthAudioClip;
        [SerializeField] private AudioClip[] abilityAudioClip;
        [SerializeField] private AudioClip[] deathAudioClip;

        private void Initialize()
        {
            AddEntityComponent(new HealthComponent(baseHealth));
            AddEntityComponent(new DamageComponent(baseDamage));
            AddEntityComponent(new TeamComponent(team));
            AddEntityComponent(new HeroAudioComponent(startAudioClips, lowHealthAudioClip, abilityAudioClip, deathAudioClip));
            AddEntityComponent(new HeroViewComponent(GetComponent<HeroView>()));
            
            AddEffect<AttackEffect>(new DamageEffect(this));
            
            OnInitialize();
        }

        public void InitializeHero()
        {
            ClearEntity();
            Initialize();
        }

        protected abstract void OnInitialize();
    }

    public enum Team
    {
        Red,
        Blue
    }
}