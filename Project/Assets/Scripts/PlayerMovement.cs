using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_runSpeed = 20.0f;

    private Rigidbody2D m_rigidBody;
    private Animator m_animator;

    private float m_horizontalInput;
    private float m_verticalInput;
    
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        m_horizontalInput = Input.GetAxisRaw("Horizontal");
        m_verticalInput = Input.GetAxisRaw("Vertical");

        if (m_verticalInput != 0 || m_horizontalInput != 0)
        {
            m_animator.SetInteger("Speed", 1);
        }
        else
        {
            m_animator.SetInteger("Speed", 0);
        }

        m_animator.SetFloat("MoveX", m_horizontalInput);
        m_animator.SetFloat("MoveY", m_verticalInput);
    }

    private void FixedUpdate()
    {
        m_rigidBody.velocity = new Vector2(m_horizontalInput * m_runSpeed, m_verticalInput * m_runSpeed);
    }
}
