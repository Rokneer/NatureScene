using UnityEngine;

public class NewtonSecondLaw : MonoBehaviour
{
    [SerializeField] float force = 0f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }
}
