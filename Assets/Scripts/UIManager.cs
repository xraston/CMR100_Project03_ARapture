using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // TV prop references
    public GameObject canvasTV;
    private bool isTVOn = false; // switches the canvas on and off

    // Big Daddy prop references
    public GameObject canvasBigDaddy;
    private bool isBigDaddyOn = false;

    // Plasmid Stand prop references
    public GameObject canvasPlasmidStand;
    private bool isPlasmidStandOn = false;

    // Voice Recorder prop references
    public GameObject canvasVoiceRecorder;
    private bool isVoiceRecorderOn = false;

    // Newpaper Stand prop references
    public GameObject canvasNewspaper;
    private bool isNewspaperOn = false;

    // Boss Character references
    public GameObject canvasBoss;
    private bool isBossOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WallTV()
    {
        if (isTVOn == false)
        {
            canvasTV.SetActive(true); // shows the button help text
            isTVOn = true; // switches the bool
        }
        else if (isTVOn == true)
        {
            canvasTV.SetActive(false); // hides the button help text
            isTVOn = false;
        }
    }

    public void BigDaddy()
    {
        if (isBigDaddyOn == false)
        {
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
            canvasBoss.SetActive(true); // shows the button help text
            isBossOn = true; // switches the bool
        }
        else if (isBossOn == true)
        {
            canvasBoss.SetActive(false); // hides the button help text
            isBossOn = false;
        }
    }
}
