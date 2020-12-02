using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Big Daddy prop references
    public GameObject canvasBigDaddy;
    public bool isBigDaddyOn = false;

    // Plasmid Stand prop references
    public GameObject canvasPlasmidStand;
    public bool isPlasmidStandOn = false;

    // Voice Recorder prop references
    public GameObject canvasVoiceRecorder;
    public bool isVoiceRecorderOn = false;

    // Newpaper Stand prop references
    public GameObject canvasNewspaper;
    public bool isNewspaperOn = false;

    // Boss Character references
    public GameObject canvasBoss;
    public bool isBossOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BigDaddy()
    {
        if (isBigDaddyOn == false)
        {
            HideOtherText();
            canvasBigDaddy.SetActive(true); // shows the button help text
            isBigDaddyOn = true; // switches the bool
        }
        else if (isBigDaddyOn == true)
        {
            canvasBigDaddy.SetActive(false); // hides the button help text
            isBigDaddyOn = false;
        }
    }

    public void PlasmidStand()
    {
        if (isPlasmidStandOn == false)
        {
            HideOtherText();
            canvasPlasmidStand.SetActive(true); // shows the button help text
            isPlasmidStandOn = true; // switches the bool
        }
        else if (isPlasmidStandOn == true)
        {
            canvasPlasmidStand.SetActive(false); // hides the button help text
            isPlasmidStandOn = false;
        }
    }

    public void VoiceRecorder()
    {
        if (isVoiceRecorderOn == false)
        {
            HideOtherText();
            canvasVoiceRecorder.SetActive(true); // shows the button help text
            isVoiceRecorderOn = true; // switches the bool
        }
        else if (isVoiceRecorderOn == true)
        {
            canvasVoiceRecorder.SetActive(false); // hides the button help text
            isVoiceRecorderOn = false;
        }
    }

    public void NewspaperStand()
    {
        if (isNewspaperOn == false)
        {
            HideOtherText();
            canvasNewspaper.SetActive(true); // shows the button help text
            isNewspaperOn = true; // switches the bool
        }
        else if (isNewspaperOn == true)
        {
            canvasNewspaper.SetActive(false); // hides the button help text
            isNewspaperOn = false;
        }
    }

    public void BossText()
    {
        if (isBossOn == false)
        {
            HideOtherText();
            canvasBoss.SetActive(true); // shows the button help text
            isBossOn = true; // switches the bool
        }
        else if (isBossOn == true)
        {
            canvasBoss.SetActive(false); // hides the button help text
            isBossOn = false;
        }
    }

    public void HideOtherText()
    {
        canvasBigDaddy.SetActive(false);
        canvasPlasmidStand.SetActive(false);
        canvasVoiceRecorder.SetActive(false);
        canvasNewspaper.SetActive(false);
        canvasBoss.SetActive(false);

        isBigDaddyOn = false;
        isPlasmidStandOn = false;
        isVoiceRecorderOn = false;
        isNewspaperOn = false;
        isBossOn = false;
    }
}
