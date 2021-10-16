using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverDetector : MonoBehaviour
{

    public BoxCollider2D bounds;

    private Rigidbody2D rb;
    private BoxCollider2D col;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (col.IsTouching(bounds))
        {
            Debug.Log("Yep");
        }
        else
        {
            Debug.Log("Nope");
        }
    }
}
