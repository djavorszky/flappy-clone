using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfMover : MonoBehaviour
{

    [Range(1f, 10f)]
    public float gameSpeed = 5f;



    void Update()
    {
        gameObject.transform.position += Vector3.left * gameSpeed * Time.deltaTime;

        if (gameObject.transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
