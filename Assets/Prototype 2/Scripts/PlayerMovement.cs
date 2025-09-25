using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

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
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _vm * speed * Time.fixedDeltaTime);
    }
}

