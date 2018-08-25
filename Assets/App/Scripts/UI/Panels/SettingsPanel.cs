using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel : BasicPanelNavigation
{
    [Header("Components")]
    [SerializeField] private Toggle TglApp;
    [SerializeField] private Toggle TglCamera;
    [SerializeField] private Toggle TglNetwork;
    [SerializeField] private Toggle TglOther;
    [SerializeField] private GameObject App;
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject Network;
    [SerializeField] private GameObject Other;

    protected override void Start()
    {
        base.Start();

        TglApp.onValueChanged.AddListener((value) =>
        {
            if (!value) return;

            App.SetActive(true);
            Camera.SetActive(false);
            Network.SetActive(false);
            Other.SetActive(false);
        });

        TglCamera.onValueChanged.AddListener((value) =>
        {
            if (!value) return;

            Camera.SetActive(true);
            App.SetActive(false);
            Network.SetActive(false);
            Other.SetActive(false);
        });

        TglNetwork.onValueChanged.AddListener((value) =>
        {
            if (!value) return;

            Network.SetActive(true);
            Camera.SetActive(false);
            App.SetActive(false);
            Other.SetActive(false);
        });

        TglOther.onValueChanged.AddListener((value) =>
        {
            if (!value) return;

            Other.SetActive(true);
            Camera.SetActive(false);
            Network.SetActive(false);
            App.SetActive(false);
        });
    }
}