using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.back * speed * horizontalInput, ForceMode.Acceleration);
        rb.AddForce(Vector3.right *  speed * verticalInput, ForceMode.Acceleration);
    }
}
