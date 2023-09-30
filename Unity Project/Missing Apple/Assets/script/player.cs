using UnityEngine;

class player : MonoBehaviour
{
    public float moveSpeed;
    float x, y;
    Vector2 targetPos;

    Rigidbody2D rb;

    SpriteRenderer sp;

    public float jumpForce;

    bool isGrounded;

    public Transform groundCheck;

    public LayerMask groundlayer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        sp = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        
    }

    private void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();
            }
        }

    }

    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        

        transform.Translate(x * moveSpeed, y * moveSpeed, 0);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.02f, groundlayer);
        plat();
        
    }
    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
    void plat()
    {
        rb.velocity = new Vector2(moveSpeed * x, rb.velocity.y);
    }
   
}
