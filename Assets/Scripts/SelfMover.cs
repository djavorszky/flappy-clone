using UnityEngine;

public class SelfMover : MonoBehaviour
{

    [Range(1f, 10f)]
    public float gameSpeed = 5f;


    public float despawnLocationOnX = -15;

    void Update()
    {
        gameObject.transform.position += Vector3.left * gameSpeed * Time.deltaTime;
    }
}
