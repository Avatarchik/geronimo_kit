using System;
using GeronimoKit.UI.Panels.Basic;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Panels
{
    public class WalkthroughPanel : BasicPanel
    {
        [Header("Components")]
        [SerializeField] private Button _btnGetStarted = default;

        public event Action OnClick;

        protected override void Start()
        {
            base.Start();

            _btnGetStarted.onClick.AddListener(() =>
            {
                OnClick?.Invoke();
            });
        }
    }
}
