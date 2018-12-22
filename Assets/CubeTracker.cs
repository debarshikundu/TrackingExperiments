using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CubeTracker : MonoBehaviour
{

    private bool logging = true;
    string filepath = null;


    void Awake()
    {
        filepath = Application.dataPath + "/User.txt";
        File.WriteAllText(filepath, "The user cube visited these random coordinates: \n\n");
        StartCoroutine(LogPosition());
    }

    private IEnumerator LogPosition()
    {
        while (logging)
        {
            PrintPoint(transform.position);
            yield return new WaitForSeconds(3f);
        }
    }

    void PrintPoint(Vector3 position)
    { 
        File.AppendAllText(filepath, string.Format("{0}\n\n", JsonUtility.ToJson(position)));
    }

}