using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // �berpr�fen, ob der Spieler auf dem Boden steht
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundLayer);
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundLayer);
        // Springen, wenn der Spieler auf dem Boden steht und die Leertaste gedr�ckt wird
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
