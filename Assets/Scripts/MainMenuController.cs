using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameObject settingsPanel;

    void Start()
    {
        settingsPanel.SetActive(false); // �⺻�� ��Ȱ��ȭ
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }
}
