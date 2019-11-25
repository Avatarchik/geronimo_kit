using System;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Panels.Basic
{
    public class BasicPanelNavigation : BasicPanel
    {
        [SerializeField] private Button _btnBack  = default;

        public event Action OnBack;

        protected override void Start()
        {
            base.Start();

            _btnBack.onClick.AddListener(() =>
            {
                OnBack?.Invoke();
            });
        }
    }
}