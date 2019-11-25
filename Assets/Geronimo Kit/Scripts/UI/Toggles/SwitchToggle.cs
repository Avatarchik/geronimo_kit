using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Toggles
{
    public class SwitchToggle : MonoBehaviour
    {
        [SerializeField] private Image _imgBackground = default;
        [SerializeField] private Image _imgOff = default;
        [SerializeField] private Image _imgOn = default;

        private Toggle _tglSwitch;
        private Color _color;

        private void Start()
        {
            _tglSwitch = GetComponent<Toggle>();
            _color = _imgBackground.color;

            if (_tglSwitch != null)
            {
                if (_tglSwitch.isOn)
                {
                    _imgBackground.color = Color.green;
                }

                _tglSwitch.onValueChanged.AddListener((value) =>
                {
                    if (value)
                    {
                        _imgBackground.color = Color.green;
                        _imgOff.gameObject.SetActive(false);
                        _imgOn.gameObject.SetActive(true);
                    }
                    else
                    {
                        _imgBackground.color = _color;
                        _imgOn.gameObject.SetActive(false);
                        _imgOff.gameObject.SetActive(true);
                    }
                });
            }
        }
    }
}