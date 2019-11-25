using System;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Buttons.Settings
{
    public enum ESettingsType
    {
        FontSize = 0,
        FontCustom = 1,
        Language = 2,
        Theme = 3,
    }

    public class SettingButton : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private Text _txtSetting = default;
        [SerializeField] private ESettingsType _type = default;

        private Button _btnSetting;

        public event Action<ESettingsType> OnClick;

        public ESettingsType Type
        {
            get => _type;
            set => _type = value;
        }

        private void Start()
        {
            _btnSetting = GetComponent<Button>();

            if (_btnSetting != null)
            {
                _btnSetting.onClick.AddListener(() => { OnClick?.Invoke(Type); });
            }
        }

        public void SetText(string paramName)
        {
            if (_txtSetting != null)
            {
                _txtSetting.text = paramName;
            }
        }
    }
}