using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public UIManager uiManager;

    public Animator bossAnimator;

    public float scaleAmount = 1.5f;

    public AudioSource recorder;
    public AudioSource click;
    public AudioSource mumble;

    public GameObject syringe;

    public GameObject bigDaddy;
    public GameObject plasmidStand;
    public GameObject newspaperStand;
    public GameObject voiceRecorder;
    public GameObject bossCharacter;

    private void OnMouseDown()
    {
        if (this.name == "BigDaddyG")
        {
            OriginalSize(); // resets to the original size
            uiManager.BigDaddy(); // shows/hides the UI element
            this.transform.localScale = new Vector3 (scaleAmount, scaleAmount, scaleAmount); // increases the size
            
            click.Play(); // play the click sound
            bossAnimator.Play("PointLeft"); // plays the character animation

            if (uiManager.isBigDaddyOn == false)
            {
                OriginalSize(); // resets to the original size
            }
        }

        if (this.name == "PlasmidStandG")
        {
            OriginalSize();
            uiManager.PlasmidStand();
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);

            bossAnimator.Play("PointRightForward");
            click.Play();
            syringe.SetActive(true);

            if (uiManager.isPlasmidStandOn == false)
            {
                OriginalSize();
                syringe.SetActive(false);
            }
        }

        if (this.name == "NewspaperG")
        {
            OriginalSize();
            uiManager.NewspaperStand();
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);

            bossAnimator.Play("PointLeftForward");
            click.Play();

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

            bossAnimator.Play("PointForward");
            click.Play();

            if (recorder.isPlaying == false) // if the audio is not playing
            {
                recorder.Play(); // play the audio
            }
            else if (recorder.isPlaying == true) // if the audio is playing
            {
                recorder.Pause(); // pause the audio
            }

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

            // bossAnimator.Play("PointRight");
            mumble.Play();

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
