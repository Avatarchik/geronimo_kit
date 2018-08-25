using System;
using UnityEngine;

public class MenuPanel : BasicPanel
{
    [Header("Components")]
    [SerializeField] private BasicButton BtnHome;
    [SerializeField] private BasicButton BtnProfile;
    [SerializeField] private BasicButton BtnAboutUs;
    [SerializeField] private BasicButton BtnPortfolio;
    [SerializeField] private BasicButton BtnSettings;
    [SerializeField] private BasicButton BtnLogout;

    public event Action OnHome;
    public event Action OnProfile;
    public event Action OnAboutUs;
    public event Action OnPortfolio;
    public event Action OnSettings;
    public event Action OnLogout;

    protected override void Start()
    {
        base.Start();

        BtnHome.OnClick += BtnHome_OnClick;
        BtnProfile.OnClick += BtnProfile_OnClick;
        BtnAboutUs.OnClick += BtnAboutUs_OnClick;
        BtnPortfolio.OnClick += BtnPortfolio_OnClick;
        BtnSettings.OnClick += BtnSettings_OnClick;
        BtnLogout.OnClick += BtnLogout_OnClick;
    }

    private void BtnHome_OnClick()
    {
        if (OnHome != null)
        {
            OnHome();
        }
    }

    private void BtnProfile_OnClick()
    {
        if (OnProfile != null)
        {
            OnProfile();
        }
    }

    private void BtnAboutUs_OnClick()
    {
        if (OnAboutUs != null)
        {
            OnAboutUs();
        }
    }

    private void BtnPortfolio_OnClick()
    {
        if (OnPortfolio != null)
        {
            OnPortfolio();
        }
    }

    private void BtnSettings_OnClick()
    {
        if (OnSettings != null)
        {
            OnSettings();
        }
    }

    private void BtnLogout_OnClick()
    {
        if (OnLogout != null)
        {
            OnLogout();
        }
    }
}