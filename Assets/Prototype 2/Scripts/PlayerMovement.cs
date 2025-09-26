using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Moving")]
    public float speed;

    [Header("Jumping")]
    public float jumpForce;
    bool _isGrounded = true;

    Rigidbody2D _rb;
    SpriteRenderer _sr;
    Vector2 _vm;

    public bool isVerticalMovementOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _vm.x = Input.GetAxisRaw("Horizontal");

        if (isVerticalMovementOn) _vm.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space)) Jump();
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _vm * speed * Time.fixedDeltaTime);
    }

    void Jump()
    {
        if (_isGrounded)
        {            
            Debug.Log("Read Jump Function");
            _rb.AddForce(new Vector2(_rb.linearVelocity.x, jumpForce), ForceMode2D.Impulse);
            _isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the object's layer is the Ground layer (6)
        if(collision.gameObject.layer == 6)
        {
            _isGrounded = true;
        }
    }
}

