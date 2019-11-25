using System;
using GeronimoKit.UI.Panels.Basic;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Panels
{
    public class RecoveryPanel : BasicPanel
    {
        [Header("Components")]
        [SerializeField] private Button _btnSend = default;
        [SerializeField] private Button _btnAlreadyAccount = default;

        public event Action OnSend;
        public event Action OnAlreadyAccount;

        protected override void Start()
        {
            base.Start();

            _btnSend.onClick.AddListener(() =>
            {
                OnSend?.Invoke();
            });

            _btnAlreadyAccount.onClick.AddListener(() =>
            {
                OnAlreadyAccount?.Invoke();
            });
        }
    }
}
