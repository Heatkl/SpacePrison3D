using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update


     void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Finish")
        {
            Debug.Log("YES");
            transform.position = new Vector3(37.6f, 73.5f, 0.9f);
        }
    }
}
