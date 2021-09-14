using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
            Debug.Log($"Fucker hit me {++hits} time(s)");
    }
}
