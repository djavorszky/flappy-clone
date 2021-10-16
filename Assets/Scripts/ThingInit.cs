using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
    }
}
