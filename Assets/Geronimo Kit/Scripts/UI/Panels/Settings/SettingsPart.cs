using System;
using System.Collections;
using System.Collections.Generic;
using GeronimoKit.UI.Buttons.Settings;
using UnityEngine;

namespace GeronimoKit.UI.Panels.Basic
{
    public class SettingsPart : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private SettingButton[] _settingsButton = default;

        public event Action<ESettingsType> OnClick;

        private void Start()
        {
            foreach (var button in _settingsButton)
            {
                button.OnClick += Button_OnClick;
            }
        }

        public void Init(string paramName, ESettingsType type)
        {
            foreach (var button in _settingsButton)
            {
                if (button.Type == type)
                {
                    button.SetText(paramName);
                }
            }
        }

        private void Button_OnClick(ESettingsType type)
        {
            OnClick?.Invoke(type);
        }
    }
}