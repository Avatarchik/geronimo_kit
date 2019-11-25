using System.Collections.Generic;
using System.Linq;
using GeronimoKit.Core;
using GeronimoKit.UI.Buttons.Settings;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Panels.Basic
{
    public class SettingsPanel : BasicPanelNavigation
    {
        [Header("Components")]
        [SerializeField] private Toggle _tglApp = default;
        [SerializeField] private Toggle _tglCamera = default;
        [SerializeField] private Toggle _tglNetwork = default;
        [SerializeField] private Toggle _tglOther = default;
        [SerializeField] private GameObject _app = default;
        [SerializeField] private GameObject _camera = default;
        [SerializeField] private GameObject _network = default;
        [SerializeField] private GameObject _other = default;
        [SerializeField] private GameObject _container = default;

        [Header("Parts")]
        [SerializeField] private SettingsPart _partApp = default;

        [Header("Prefabs")]
        [SerializeField] private GameObject _paramButton = default;

        private List<ParamButton> _lstParamButton;

        protected override void Start()
        {
            base.Start();

            _lstParamButton = new List<ParamButton>();

            _tglApp.onValueChanged.AddListener((value) =>
            {
                if (!value) return;

                DisableParams();

                _app.SetActive(true);
                _camera.SetActive(false);
                _network.SetActive(false);
                _other.SetActive(false);
            });

            _tglCamera.onValueChanged.AddListener((value) =>
            {
                if (!value) return;

                DisableParams();

                _camera.SetActive(true);
                _app.SetActive(false);
                _network.SetActive(false);
                _other.SetActive(false);
            });

            _tglNetwork.onValueChanged.AddListener((value) =>
            {
                if (!value) return;

                DisableParams();

                _network.SetActive(true);
                _camera.SetActive(false);
                _app.SetActive(false);
                _other.SetActive(false);
            });

            _tglOther.onValueChanged.AddListener((value) =>
            {
                if (!value) return;

                DisableParams();

                _other.SetActive(true);
                _camera.SetActive(false);
                _network.SetActive(false);
                _app.SetActive(false);
            });

            Init();
        }

        private void Init()
        {
            _partApp.OnClick += PartAppOnClick;
        }

        public void DisableParams()
        {
            _container.SetActive(false);
            DestroyElmnt();
        }

        private void PartAppOnClick(ESettingsType type)
        {
            DestroyElmnt();

            var data = LocalCore.GetDataFromJsonFromPath<ParamModel>(type.ToString(), "Settings").ToList();
            _container.SetActive(true);
            InitParams(data, type);
        }

        private void InitParams(IEnumerable<ParamModel> data, ESettingsType type)
        {
            foreach (var model in data)
            {
                var param = Instantiate(_paramButton) as GameObject;
                param.transform.SetParent(_container.transform, false);
                param.transform.localScale = Vector3.one;
                param.transform.SetAsFirstSibling();

                var button = param.GetComponent<ParamButton>();
                button.Init(model, type);

                button.OnClick += ButtonOnClick;

                _lstParamButton.Add(button);
            }
        }

        private void ButtonOnClick(string paramName, int paramId, ESettingsType type)
        {
            _container.SetActive(false);
            _partApp.Init(paramName, type);
        }

        private void DestroyElmnt()
        {
            if (_lstParamButton != null)
            {
                foreach (var elmnt in _lstParamButton)
                {
                    Destroy(elmnt.gameObject);
                }

                _lstParamButton.Clear();
            }
        }
    }
}