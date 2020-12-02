using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public UIManager uiManager;

    public float scaleAmount = 1.5f;

    public GameObject bigDaddy;
    public GameObject plasmidStand;
    public GameObject newspaperStand;
    public GameObject voiceRecorder;
    public GameObject bossCharacter;

    private void OnMouseDown()
    {
        if (this.name == "BigDaddyG")
        {
            OriginalSize();
            uiManager.BigDaddy();
            this.transform.localScale = new Vector3 (scaleAmount, scaleAmount, scaleAmount);

            if(uiManager.isBigDaddyOn == false)
            {
                OriginalSize();
            }
        }

        if (this.name == "PlasmidStandG")
        {
            OriginalSize();
            uiManager.PlasmidStand();
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);

            if (uiManager.isPlasmidStandOn == false)
            {
                OriginalSize();
            }
        }

        if (this.name == "NewspaperG")
        {
            OriginalSize();
            uiManager.NewspaperStand();
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);

            if (uiManager.isNewspaperOn == false)
            {
                OriginalSize();
            }
        }

        if (this.name == "VoiceRecorderG")
        {
            OriginalSize();
            uiManager.VoiceRecorder();
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);

            if (uiManager.isVoiceRecorderOn == false)
            {
                OriginalSize();
            }
        }

        if (this.name == "BossCharG")
        {
            OriginalSize();
            uiManager.BossText();
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);

            if (uiManager.isBossOn == false)
            {
                OriginalSize();
            }
        }
    }

    public void OriginalSize()
    {
        bigDaddy.transform.localScale = new Vector3 (1, 1, 1);
        plasmidStand.transform.localScale = new Vector3(1, 1, 1);
        newspaperStand.transform.localScale = new Vector3(1, 1, 1);
        voiceRecorder.transform.localScale = new Vector3(1, 1, 1);
        bossCharacter.transform.localScale = new Vector3(1, 1, 1);
    }
}
