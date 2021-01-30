using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_runSpeed = 20.0f;

    private Rigidbody2D m_rigidBody;

    private float m_horizontalInput;
    private float m_verticalInput;
    
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_horizontalInput = Input.GetAxisRaw("Horizontal");
        m_verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        m_rigidBody.velocity = new Vector2(m_horizontalInput * m_runSpeed, m_verticalInput * m_runSpeed);
    }
}
