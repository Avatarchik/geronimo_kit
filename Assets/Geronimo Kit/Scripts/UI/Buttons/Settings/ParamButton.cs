using System;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Buttons.Settings
{
    public class ParamButton : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private Button _btnParam = default;
        [SerializeField] private Text _txtParam = default;
        [SerializeField] private ESettingsType _type = default;

        private string _paramName;
        private int _paramId;

        public event Action<string, int, ESettingsType> OnClick;

        private void Start()
        {
            _btnParam.onClick.AddListener(() => { OnClick?.Invoke(_paramName, _paramId, _type); });
        }

        public void Init(ParamModel model, ESettingsType type)
        {
            _paramName = model.param_name;
            _paramId = model.param_id;
            _type = type;

            _txtParam.text = _paramName;
        }
    }
}