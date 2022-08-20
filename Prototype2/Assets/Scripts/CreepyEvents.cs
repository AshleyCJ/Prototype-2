using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource AS;
    public AudioClip[] CreepyAudio;
    public Animator CreepyAnim;

    private void Start()
    {
        
    }




    ///Creepy Animations to call when needed///

    public void DistortionEnding()
    {
        CreepyAnim.Play("EndDistortionAnimation");
    }

    public void BloodTap()
    {
        CreepyAnim.Play("BloodTap");
    }

    public void FigureWindow()
    {
        CreepyAnim.Play("FigureWindow");
    }

    public void PhoneCall()
    {
        CreepyAnim.Play("PhoneCall");
    }

    public void PaintingFall()
    {
        CreepyAnim.Play("PaintingFalls");
    }





    ///Audio Qeue///
    public void PlayPhoneCall()
    {
        AS.clip = CreepyAudio[0];
        AS.volume = 1;
        AS.Play();
    }
    public void PlayStatic()
    {
        AS.clip = CreepyAudio[1];
        AS.volume = 1;
        AS.Play();
    }

    public void StopAudio()
    {
        AS.Stop();
    }
    public void PlayFlickerLights()
    {
        AS.clip = CreepyAudio[2];
        AS.volume = 1;
        AS.Play();
    }

    public void PlayTape()
    {
        AS.clip = CreepyAudio[3];
        AS.volume = 1;
        AS.Play();
    }
    public void PlayFallingObject()
    {
        AS.clip = CreepyAudio[4];
        AS.volume = 1f;
        AS.Play();
    }
}
