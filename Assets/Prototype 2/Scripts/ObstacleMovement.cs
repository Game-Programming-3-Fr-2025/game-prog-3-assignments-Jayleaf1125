using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed;
    public Transform leftBorder;
    public Transform rightBorder;

    [SerializeField] float _borderRadius;
    Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(leftBorder.position, _borderRadius);
        Gizmos.DrawWireSphere(rightBorder.position, _borderRadius);
    }
}
