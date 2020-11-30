using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public UIManager uiManager;

    private void OnMouseDown()
    {
        if (this.name == "BigDaddy")
        {
            uiManager.BigDaddy();
        }

        if (this.name == "WallTV")
        {
            uiManager.WallTV();
        }

        if (this.name == "PlasmidStand")
        {
            uiManager.PlasmidStand();
        }

        if (this.name == "Newspaper")
        {
            uiManager.NewspaperStand();
        }

        if (this.name == "VoiceRecorder")
        {
            uiManager.VoiceRecorder();
        }

        if (this.name == "Boss")
        {
            uiManager.BossText();
        }

    }
}
