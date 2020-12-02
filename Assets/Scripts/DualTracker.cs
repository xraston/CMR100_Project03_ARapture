using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Vuforia;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class DualTracker : MonoBehaviour, ITrackableEventHandler
{
    public enum Orientation
    {
        horizontal,
        vertical
    }

    public Orientation currentRotation; // this can only be the value of horizontal or vertical results

    public Transform arCamera;
    public TrackableBehaviour trackableBehaviour; // a reference to our AR marker script

    private Transform rotationalHelper; // a runtime transform create to assist with determining the orientation of the marker

    public float trackerthreshold = 0.6f; // this determines when the marker is horizontal or vertical

    public Text debugDeviceAngle; // a piece of text used to show what angle a device is
    public Text debugMarkerOrientation; // a piece of text used to show what orientation the marker currently is

    public bool trackerFound = false; // have we detected a tracker?

    public float currentAngleCompared; // this is going to be the current value of our angle comparisons

    public GameObject gameWorld; // a reference to our game world

    public Transform verticalTracker; // vertical tracker reference
    public Transform horizontalTracker; // horizontal tracker reference

    // Start is called before the first frame update
    void Start()
    {
        // if the reference has been assigned
        if(trackableBehaviour != null)
        {
            trackableBehaviour.RegisterTrackableEventHandler(this);
        }
        rotationalHelper = new GameObject(trackableBehaviour.TrackableName.ToString() + "Rotation Helper").transform; // we are creating an empty gameobject and giving it the same name as the tracker
        rotationalHelper.position = Vector3.zero; // reset it's postion to 0,0,0
        rotationalHelper.rotation = Quaternion.identity; // resets it's rotation to 0,0,0,0
        OnTrackingLost(); // hide everything
    }

    // Update is called once per frame
    void Update()
    {
        if(debugDeviceAngle != null)
        {
            debugDeviceAngle.text = "Current Angle: " + currentAngleCompared; // set the text to the angle
        }
        if(debugMarkerOrientation != null)
        {
            debugMarkerOrientation.text = currentRotation.ToString(); // set the text to the rotation
        }
        
    }

    /// <summary>
    /// A Vuforia function we need to implement to detect changes with the makers
    /// </summary>
    /// <param name="previousStatus"></param>
    /// <param name="newStatus"></param>
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        // checking the current status of the marker
        if(newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if(trackerFound == true)
            {
                trackerFound = false;
                OnTrackingFound(); // we got tracking
            }
        }
        else
        {
            if (trackerFound == false)
            {
                trackerFound = true;
                OnTrackingLost(); // we lost tracking
            }
        }
    }

    /// <summary>
    /// what we want to do when the marker is found
    /// </summary>
    private void OnTrackingFound()
    {
        UpdateTrackerRotation(); // update the tracker rotation of the tracker
        gameWorld.SetActive(true); // turn our game world on
        Time.timeScale = 1; // resume the game
        AudioListener.pause = false; // resume the audio

    }

    /// <summary>
    /// what we want to do when the marker is lost
    /// </summary>
    private void OnTrackingLost()
    {
        gameWorld.SetActive(false); // turn our game world off
        Time.timeScale = 0; // pause the game
        AudioListener.pause = true; // pause the audio
    }

    /// <summary>
    /// gets and updates rotation of the device's camera
    /// </summary>
    void UpdateTrackerRotation()
    {
        ConvertDeviceRotation(); // convert the current device input

        rotationalHelper.eulerAngles = new Vector3(rotationalHelper.eulerAngles.x, arCamera.eulerAngles.y, arCamera.eulerAngles.z); // get camera's local y & z orientation and match it to the rotation helper
        currentAngleCompared = Vector3.Dot(rotationalHelper.rotation * Vector3.forward, arCamera.forward); // compare difference in the world forward and the AR camera's forward direction

        if(currentAngleCompared <trackerthreshold)
        {
            // at less than threshold then must be horizontal
            currentRotation = Orientation.horizontal;
            transform.position = horizontalTracker.position; // set the postion to the horizontal tracker
            transform.rotation = horizontalTracker.rotation; // set the rotation to the horizontal tracker
        }
        else if(currentAngleCompared > trackerthreshold)
        {
            // at more than threshold then must be vertical
            currentRotation = Orientation.vertical;
            transform.position = verticalTracker.position; // set the postion to the vertical tracker
            transform.rotation = verticalTracker.rotation; // set the rotation to the vertical tracker
        }
    }

    /// <summary>
    /// take the device's gyroscope information and convert it so unity can hangle the input
    /// 
    private void ConvertDeviceRotation()
    {
        rotationalHelper.rotation = Input.gyro.attitude; // match the rotation of the gyro
        rotationalHelper.Rotate(0, 0, 180f, Space.Self); // rotate around local axis and swap it from the gyro's input
        rotationalHelper.Rotate(90, 180, 0f, Space.World); // rotate it to make snese of the camera facing from the back of the phone camera // save the rotation
    }
    
}
