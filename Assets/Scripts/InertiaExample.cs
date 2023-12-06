using UnityEngine;

public class InertiaExample : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(Vector3.right * 1f, ForceMode.Impulse);
        }
        
    }
}
