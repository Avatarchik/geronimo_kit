using System;
using GeronimoKit.UI.Buttons.Basic;
using GeronimoKit.UI.Panels.Basic;
using UnityEngine;

namespace GeronimoKit.UI.Panels
{
    public class MenuPanel : BasicPanel
    {
        [Header("Components")]
        [SerializeField] private BasicMenuButton _btnHome = default;
        [SerializeField] private BasicMenuButton _btnProfile = default;
        [SerializeField] private BasicMenuButton _btnAboutUs = default;
        [SerializeField] private BasicMenuButton _btnPortfolio = default;
        [SerializeField] private BasicMenuButton _btnSettings = default;
        [SerializeField] private BasicMenuButton _btnLogout = default;

        public event Action OnHome;
        public event Action OnProfile;
        public event Action OnAboutUs;
        public event Action OnPortfolio;
        public event Action OnSettings;
        public event Action OnLogout;

        protected override void Start()
        {
            base.Start();

            _btnHome.OnClick += BtnHome_OnClick;
            _btnProfile.OnClick += BtnProfile_OnClick;
            _btnAboutUs.OnClick += BtnAboutUs_OnClick;
            _btnPortfolio.OnClick += BtnPortfolio_OnClick;
            _btnSettings.OnClick += BtnSettings_OnClick;
            _btnLogout.OnClick += BtnLogout_OnClick;
        }

        private void BtnHome_OnClick()
        {
            OnHome?.Invoke();
        }

        private void BtnProfile_OnClick()
        {
            OnProfile?.Invoke();
        }

        private void BtnAboutUs_OnClick()
        {
            OnAboutUs?.Invoke();
        }

        private void BtnPortfolio_OnClick()
        {
            OnPortfolio?.Invoke();
        }

        private void BtnSettings_OnClick()
        {
            OnSettings?.Invoke();
        }

        private void BtnLogout_OnClick()
        {
            OnLogout?.Invoke();
        }
    }
}