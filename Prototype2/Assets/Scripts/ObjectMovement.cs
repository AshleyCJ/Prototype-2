using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectMovement : MonoBehaviour
{
    public Animator EventsAnimator;
    //Funitutre Items
    public GameObject Top_Fridge;
    private bool Top_Fridge_Open;
    public GameObject Bottom_Fridge;
    private bool Bottom_Fridge_Open;
    public GameObject Oven;
    private bool Oven_Open;
    private bool OvenAnimationPlaying;
    public GameObject Cab1;
    private bool Cab1_Open;
    public GameObject Cab2;
    private bool Cab2_Open;
    public GameObject Cab3;
    private bool Cab3_Open;
    public GameObject Cab4;
    private bool Cab4_Open;
    public GameObject SinkCab1;
    private bool SinkCab1_Open;
    public GameObject SinkCab2;
    private bool SinkCab2_Open;
    public GameObject Blanket;
    private bool Blanket_Open;

    public GameObject Curtain;
    private bool CurtainOpen;
    private bool CurtainAnimation;

    // Puzzle items, make the bools public to lock/unlock the items from another script
    public GameObject Book;
    public GameObject BookHinge;
    private bool Book_Open;

    public GameObject PlasticWrappedBox;
    private bool PlasticWrappedBox_Open;

    public GameObject Door;
    public GameObject DoorHinge;
    private bool DoorOpen;

    public GameObject BoxWithCode;
    public GameObject BoxHinge;
    private bool BoxWithCode_Open;

    public CreepyEvents CE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
       
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    //Our custom method. 
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                }
            }
        }
    }

    public void CurrentClickedGameObject(GameObject gameObject)
    {
        if (gameObject == Top_Fridge)
        {
            if (!Top_Fridge_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, -20), 2);
                Top_Fridge_Open = true;
            }else if (Top_Fridge_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 90), 2);
                Top_Fridge_Open = false;
            }
        }
        else if (gameObject == Bottom_Fridge)
        {
            if (!Bottom_Fridge_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, -20), 2);
                Bottom_Fridge_Open = true;
            }
            else if (Bottom_Fridge_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 90), 2);
                Bottom_Fridge_Open = false;
            }
        }
        else if (gameObject == Cab1)
        {
            if (!Cab1_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 180), 2);
                Cab1_Open = true;
            }
            else if (Cab1_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 90), 2);
                Cab1_Open = false;
            }
        }
        else if (gameObject == Cab2)
        {
            if (!Cab2_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, -20), 2);
                Cab2_Open = true;
            }
            else if (Cab2_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 90), 2);
                Cab2_Open = false;
            }
        }
        else if (gameObject == Cab3)
        {
            if (!Cab3_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 150), 2);
                Cab3_Open = true;
            }
            else if (Cab3_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 90), 2);
                Cab3_Open = false;
            }
        }
        else if (gameObject == Cab4)
        {
            if (!Cab4_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, -20), 2);
                Cab4_Open = true;
            }
            else if (Cab4_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 90), 2);
                Cab4_Open = false;
            }
        }
        else if (gameObject == SinkCab1)
        {
            if (!SinkCab1_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 180), 2);
                SinkCab1_Open = true;
            }
            else if (SinkCab1_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 90), 2);
                SinkCab1_Open = false;
            }
        }
        else if (gameObject == SinkCab2)
        {
            if (!SinkCab2_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, -20), 2);
                SinkCab2_Open = true;
            }
            else if (SinkCab2_Open)
            {
                gameObject.transform.DORotate(new Vector3(-90, 0, 90), 2);
                SinkCab2_Open = false;
            }
        }
        else if (gameObject == Oven)///// Cant get it to open correctly
        {
            if (!OvenAnimationPlaying)
            {
                //Debug.Log("HIT OVEN");
                if (!Oven_Open)
                {


                    gameObject.GetComponent<Animator>().Play("Oven_Open");
                    Oven_Open = true;
                    StartCoroutine(AnimationFinishOven());
                }
                else if (Oven_Open)
                {

                    gameObject.GetComponent<Animator>().Play("Oven_Close");
                    Oven_Open = false;
                    StartCoroutine(AnimationFinishOven());
                }
            }
        }
        else if (gameObject == Curtain)
        {
            if (!CurtainAnimation)
            {


                if (!CurtainOpen)
                {
                    gameObject.GetComponent<Animator>().Play("CurtainOpen");
                    CurtainOpen = true;
                    StartCoroutine(AnimationFinishCurtain());

                    int EventChance = Random.Range(0, 3);
                    if (EventChance == 0)
                    {
                        CE.FigureWindow();
                    }
                }
                else if (CurtainOpen)
                {
                    gameObject.GetComponent<Animator>().Play("CurtainClose");
                    CurtainOpen = false;
                    StartCoroutine(AnimationFinishCurtain());
                }
            }
        }
        else if (gameObject == Blanket)
        {
            
            if (!Blanket_Open)
            {


                gameObject.GetComponent<Animator>().Play("BlanketMove");
                Blanket_Open = true;
            }
            
        }

        ///PUZZLE OBJECTS///
        //Objects that can be 'locked' until player has required item to unlock it. Make the objects bool 'true' to keep locked and when unlocked make it 'false'
        // ie the box with the code must be locked until the correct code it put in. The "CodeBox_Open" bool must start as true to keep it locked. When the correct code is
        //put in the bool must then = false. This will allow the opening animation to play when being clicked on.
        else if( gameObject == Book)
        {
            if(!Book_Open)
            {
               
                BookHinge.GetComponent<Animator>().Play("BookOpen");
                Book_Open = true;
            }
        }
        else if (gameObject == PlasticWrappedBox)
        {
            if (!PlasticWrappedBox_Open)
            {

                PlasticWrappedBox.GetComponent<Animator>().Play("PlasticWrappedBox_Open");
                PlasticWrappedBox_Open = true;
            }
        }
        else if(gameObject == Door)
        {
            if(!DoorOpen)
            {
                DoorHinge.GetComponent<Animator>().Play("DoorOpen");
                DoorOpen = true;
                CE.DistortionEnding();
            }
        }
        else if(gameObject == BoxWithCode)
        {
            if(!BoxWithCode_Open)
            {
              BoxHinge.GetComponent<Animator>().Play("BoxCodeOpen");
                BoxWithCode_Open = true;

            }
        }
    }
    IEnumerator AnimationFinishOven()
    {
        OvenAnimationPlaying = true;
        yield return new WaitForSeconds(2);
        OvenAnimationPlaying = false;
    }
    IEnumerator AnimationFinishCurtain()
    {
        CurtainAnimation = true;
        yield return new WaitForSeconds(2.1f);
        CurtainAnimation = false;
    }
}
