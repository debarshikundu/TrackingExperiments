using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CubeTracker : MonoBehaviour {

    private bool logging = true;

    void Awake()
    {
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
        string filepath = Application.dataPath + "/User.txt";
        if (File.Exists(filepath) == false)
        {
            File.WriteAllText(filepath, "The player blob visited these random coordinates: \n\n");
        }
        File.AppendAllText(filepath, string.Format("{0}\n\n", JsonUtility.ToJson(position)));
    }

}
