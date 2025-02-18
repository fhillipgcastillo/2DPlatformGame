using UnityEngine;

public class player_controller : MonoBehaviour
{
    public int speed { get; set; }
    private Rigidbody2D rb;
    public float horizontalMovement { get; set; }
    public float verticalMovement { get; set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal"); // exact
        verticalMovement = Input.GetAxis("Vertical");
        Debug.Log("horizontalMovement: " + horizontalMovement);
        Debug.Log("verticalMovement: " + verticalMovement);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalMovement * speed, verticalMovement * speed);
    }
}
