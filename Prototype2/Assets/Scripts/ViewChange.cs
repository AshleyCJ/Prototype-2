using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChange : MonoBehaviour
{
    public Camera MainCamera;

    int WallFacing;
    bool IsRotating;
    bool Started;
    //Vector3 NewDirection;
    //Vector3 CurrentDirection;
    Quaternion NewDirection;
    Quaternion CurrentDirection;
    float RotateSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        WallFacing = 0;
        //CurrentDirection = new Vector3(0, 0, 0);
        CurrentDirection = Quaternion.Euler(0, 0, 0);
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            WallFacing--;
            if (WallFacing == -1)
            {
                WallFacing = 3;
            }
        }
        if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            WallFacing++;
            if (WallFacing == 4)
            {
                WallFacing = 0;
            }
        }
        switch (WallFacing)
        {
            case 0:
                MainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 1:
                MainCamera.transform.rotation = Quaternion.Euler(0, 90, 0);
                break;
            case 2:
                MainCamera.transform.rotation = Quaternion.Euler(0, 180, 0);
                break;
            default:
                MainCamera.transform.rotation = Quaternion.Euler(0, 270, 0);
                break;
        }
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            Started = false;
            if (IsRotating == false)
            {
                IsRotating = true;
                //rotate left
                WallFacing--;
                //NewDirection = new Vector3(0, Mathf.RoundToInt(CurrentDirection.y) - 90, 0);
                NewDirection = Quaternion.Euler(0, Mathf.Round((CurrentDirection.y / 90) * 90) - 90, 0);
                if (WallFacing == -1)
                {
                    WallFacing = 3;
                }
                Invoke("HasStarted", 2f);
            }
        }
        if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            Started = false;
            if (IsRotating == false)
            {
                IsRotating = true;
                //rotate right
                WallFacing++;
                //NewDirection = new Vector3(0, Mathf.RoundToInt(CurrentDirection.y) + 90, 0);
                NewDirection = Quaternion.Euler(0, Mathf.Round((CurrentDirection.y / 90) * 90) + 90, 0);
                if (WallFacing == 4)
                {
                    WallFacing = 0;
                }
                Invoke("HasStarted", 2f);
            }
        }

        if (IsRotating)
        {
            //CurrentDirection = new Vector3(MainCamera.transform.rotation.x, MainCamera.transform.rotation.y, MainCamera.transform.rotation.z);
            CurrentDirection = MainCamera.transform.rotation;
            //MainCamera.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(CurrentDirection, NewDirection, RotateSpeed * Time.deltaTime, 100f));
            MainCamera.transform.rotation = Quaternion.RotateTowards(CurrentDirection, NewDirection, RotateSpeed * Time.deltaTime);
            //if (Mathf.Approximately(CurrentDirection.y, NewDirection.y))
            //if (CurrentDirection.y == NewDirection.y)
            if (((CurrentDirection.y <= NewDirection.y + 0.001f) || (CurrentDirection.y >= NewDirection.y - 0.001f)) && (Started))
            {
                CurrentDirection = NewDirection;
                IsRotating = false;
                Started = false;
                Debug.Log("stop rotating");
            }
        }
    }

    void HasStarted()
    {
        Started = true;
    }
    */
}
