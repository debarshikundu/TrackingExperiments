using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]

public class UserController : MonoBehaviour {
   

    bool shiftOn = false;

    void OnMouseDrag()
    {

        if (Input.GetMouseButton(0))
        {
            if(shiftOn)
            {
                //3D Drag, courtesy of Unity Forums
                float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
            }

            else
            {
                //Plane Drag
                float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
                Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
                transform.position = new Vector3(pos_move.x, transform.position.y, pos_move.z);
            }



        }

      }

    void changeShift()
    {
        shiftOn = !shiftOn;
    }

    // Use this for initialization
    void Start()
    {

    }
        // Update is called once per frame
        void Update()
        {
            OnMouseDrag();
            if (Input.GetKey(KeyCode.LeftShift)||Input.GetKey(KeyCode.RightShift))
            {
            changeShift();
            }




        }



    }




