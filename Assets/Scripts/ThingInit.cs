using UnityEngine;

public class ThingInit : MonoBehaviour
{
    void Start() => gameObject.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
}
