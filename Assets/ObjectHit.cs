using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Fucker hit me");
    }
}
    