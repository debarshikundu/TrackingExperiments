using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]

public class UserController : MonoBehaviour {
    /*
    public int speed = 20;
    static Vector3 m_DistanceFromCamera;
    public float m_DistanceZ;
    public GameObject m_Cube;
    private Plane xy_plane; 
    private Plane xz_plane;
    */

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
        /*
        m_DistanceFromCamera = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z - m_DistanceZ);
        xy_plane = new Plane(Vector3.forward, m_DistanceFromCamera);
        xz_plane = new Plane(Vector3.up, m_DistanceFromCamera);
        */

    }
        // Update is called once per frame
        void Update()
        {
            if(Input.GetKey(KeyCode.LeftShift)||Input.GetKey(KeyCode.RightShift))
            {
            changeShift();
            }

        OnMouseDrag();
            /*
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                //Initialise the enter variable
                float enter = 0.0f;
                Vector3 hitPoint = new Vector3();
                if (xy_plane.Raycast(ray, out enter))
                {
                    hitPoint = ray.GetPoint(enter);
                }

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    m_Cube.transform.position = hitPoint;
                }
                }
                */

            //Detect when there is a mouse click


        }



        /*
        // get input data from keyboard or controller
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // update player position based on input
        Vector3 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.z += moveVertical * speed * Time.deltaTime;
        transform.position = position;
        */


    }


    /*
    void OnMouseDrag()
        {

            if(Input.GetMouseButton(0))
            {

                    float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
                    transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));



            }

            }
               */


