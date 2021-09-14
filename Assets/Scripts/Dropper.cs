using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeToDrop;

    private Rigidbody body;
    private MeshRenderer mesh;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();

        body.useGravity = false;
        mesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToDrop)
        {
            body.useGravity = true;
            mesh.enabled = true;
        }
    }
}
