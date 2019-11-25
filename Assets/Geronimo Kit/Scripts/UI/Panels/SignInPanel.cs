using System;
using GeronimoKit.UI.Panels.Basic;
using UnityEngine;
using UnityEngine.UI;

namespace GeronimoKit.UI.Panels
{
    public class SignInPanel : BasicPanel
    {
        [Header("Components")]
        [SerializeField] private Button _btnLogin = default;
        [SerializeField] private Button _btnCreate = default;
        [SerializeField] private Button _btnForgot = default;

        public event Action OnLogin;
        public event Action OnCreate;
        public event Action OnForgot;

        protected override void Start()
        {
            base.Start();

            _btnLogin.onClick.AddListener(() =>
            {
                OnLogin?.Invoke();
            });

            _btnCreate.onClick.AddListener(() =>
            {
                OnCreate?.Invoke();
            });

            _btnForgot.onClick.AddListener(() =>
            {
                OnForgot?.Invoke();
            });
        }
    }
}
