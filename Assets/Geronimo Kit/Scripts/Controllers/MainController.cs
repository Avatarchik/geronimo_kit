using GeronimoKit.UI.Panels;
using GeronimoKit.UI.Panels.Basic;
using UnityEngine;

namespace GeronimoKit.Controllers
{
    public class MainController : MonoBehaviour
    {
        [Header("Panels")] 
        [SerializeField] private LogoPanel _logoPanel = default;
        [SerializeField] private MenuPanel _menuPanel = default;
        [SerializeField] private SignInPanel _signInPanel = default;
        [SerializeField] private SignUpPanel _signUpPanel = default;
        [SerializeField] private RecoveryPanel _recoveryPanel = default;
        [SerializeField] private TermsPanel _termsPanel = default;
        [SerializeField] private WalkthroughPanel _walkThroughPanel = default;
        [SerializeField] private ProfilePanel _profilePanel = default;
        [SerializeField] private AboutUsPanel _aboutUsPanel = default;
        [SerializeField] private HomePanel _homePanel = default;
        [SerializeField] private PortfolioPanel _portfolioPanel = default;
        [SerializeField] private SettingsPanel _settingsPanel = default;

        private void Start()
        {
            _signUpPanel.OnSignUp += SignUpPanelOnSignUp;
            _signUpPanel.OnAlreadyAccount += SignUpPanelOnAlreadyAccount;

            _signInPanel.OnLogin += SignInPanelOnLogin;
            _signInPanel.OnCreate += SignInPanelOnCreate;
            _signInPanel.OnForgot += SignInPanelOnForgot;

            _recoveryPanel.OnSend += RecoveryPanelOnSend;
            _recoveryPanel.OnAlreadyAccount += RecoveryPanelOnAlreadyAccount;

            _walkThroughPanel.OnClick += WalkThroughPanelOnClick;

            _menuPanel.OnHome += MenuPanelOnHome;
            _menuPanel.OnProfile += MenuPanelOnProfile;
            _menuPanel.OnAboutUs += MenuPanelOnAboutUs;
            _menuPanel.OnPortfolio += MenuPanelOnPortfolio;
            _menuPanel.OnSettings += MenuPanelOnSettings;
            _menuPanel.OnLogout += MenuPanelOnLogout;

            _profilePanel.OnBack += ProfilePanelOnBack;
            _aboutUsPanel.OnBack += AboutUsPanelOnBack;
            _homePanel.OnBack += HomePanelOnBack;
            _portfolioPanel.OnBack += PortfolioPanelOnBack;
            _settingsPanel.OnBack += SettingsPanelOnBack;

            Init();
        }

        private void OnDisable()
        {
            _signUpPanel.OnSignUp -= SignUpPanelOnSignUp;
            _signUpPanel.OnAlreadyAccount -= SignUpPanelOnAlreadyAccount;

            _signInPanel.OnLogin -= SignInPanelOnLogin;
            _signInPanel.OnCreate -= SignInPanelOnCreate;
            _signInPanel.OnForgot -= SignInPanelOnForgot;

            _recoveryPanel.OnSend -= RecoveryPanelOnSend;
            _recoveryPanel.OnAlreadyAccount -= RecoveryPanelOnAlreadyAccount;

            _walkThroughPanel.OnClick -= WalkThroughPanelOnClick;

            _menuPanel.OnHome -= MenuPanelOnHome;
            _menuPanel.OnProfile -= MenuPanelOnProfile;
            _menuPanel.OnAboutUs -= MenuPanelOnAboutUs;
            _menuPanel.OnPortfolio -= MenuPanelOnPortfolio;
            _menuPanel.OnSettings -= MenuPanelOnSettings;
            _menuPanel.OnLogout -= MenuPanelOnLogout;

            _profilePanel.OnBack -= ProfilePanelOnBack;
            _aboutUsPanel.OnBack -= AboutUsPanelOnBack;
            _homePanel.OnBack -= HomePanelOnBack;
            _portfolioPanel.OnBack -= PortfolioPanelOnBack;
            _settingsPanel.OnBack -= SettingsPanelOnBack;
        }

        private void Init()
        {
            _walkThroughPanel.SetActive(true);
        }

        private void WalkThroughPanelOnClick()
        {
            _walkThroughPanel.SetActive(false);

            _logoPanel.SetActive(true);
            _termsPanel.SetActive(true);
            _signUpPanel.SetActive(true);
        }

        private void SignUpPanelOnSignUp()
        {
        }

        private void SignUpPanelOnAlreadyAccount()
        {
            _signUpPanel.SetActive(false);

            _signInPanel.SetActive(true);
        }

        private void SignInPanelOnLogin()
        {
            _logoPanel.SetActive(false);
            _termsPanel.SetActive(false);
            _signInPanel.SetActive(false);

            _menuPanel.SetActive(true);
        }

        private void SignInPanelOnCreate()
        {
            _signInPanel.SetActive(false);

            _signUpPanel.SetActive(true);
        }

        private void SignInPanelOnForgot()
        {
            _signInPanel.SetActive(false);

            _recoveryPanel.SetActive(true);
        }

        private void RecoveryPanelOnSend()
        {
        }

        private void RecoveryPanelOnAlreadyAccount()
        {
            _recoveryPanel.SetActive(false);

            _signInPanel.SetActive(true);
        }

        private void ProfilePanelOnBack()
        {
            _profilePanel.SetActive(false);

            _menuPanel.SetActive(true);
        }

        private void MenuPanelOnHome()
        {
            _menuPanel.SetActive(false);

            _homePanel.SetActive(true);
        }

        private void MenuPanelOnProfile()
        {
            _menuPanel.SetActive(false);

            _profilePanel.SetActive(true);
        }

        private void MenuPanelOnAboutUs()
        {
            _menuPanel.SetActive(false);

            _aboutUsPanel.SetActive(true);
        }

        private void MenuPanelOnPortfolio()
        {
            _menuPanel.SetActive(false);

            _portfolioPanel.SetActive(true);
        }

        private void MenuPanelOnSettings()
        {
            _menuPanel.SetActive(false);

            _settingsPanel.DisableParams();
            _settingsPanel.SetActive(true);
        }

        private void AboutUsPanelOnBack()
        {
            _aboutUsPanel.SetActive(false);

            _menuPanel.SetActive(true);
        }

        private void HomePanelOnBack()
        {
            _homePanel.SetActive(false);

            _menuPanel.SetActive(true);
        }

        private void PortfolioPanelOnBack()
        {
            _portfolioPanel.SetActive(false);

            _menuPanel.SetActive(true);
        }

        private void SettingsPanelOnBack()
        {
            _settingsPanel.SetActive(false);

            _menuPanel.SetActive(true);
        }

        private void MenuPanelOnLogout()
        {
            _menuPanel.SetActive(false);

            _walkThroughPanel.SetActive(true);
        }
    }
}