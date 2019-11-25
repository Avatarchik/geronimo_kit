using System;
using GeronimoKit.UI.Panels.Basic;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Panels
{
    public class SignUpPanel : BasicPanel
    {
        [Header("Components")]
        [SerializeField] private Button _btnSignUp = default;
        [SerializeField] private Button _btnAlreadyAccount = default;

        public event Action OnAlreadyAccount;
        public event Action OnSignUp;

        protected override void Start()
        {
            base.Start();

            _btnAlreadyAccount.onClick.AddListener(() =>
            {
                OnAlreadyAccount?.Invoke();
            });

            _btnSignUp.onClick.AddListener(() =>
            {
                OnSignUp?.Invoke();
            });
        }
    }
}
