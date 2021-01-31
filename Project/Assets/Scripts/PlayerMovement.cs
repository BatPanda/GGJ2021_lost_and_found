using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_runSpeed = 20.0f;

    private Rigidbody2D m_rigidBody;
    private Animator m_animator;

    private float m_horizontalInput = 0;
    private float m_verticalInput = 0;

    public GameObject markerSample;

    private float timer = 0;
    public float timeBetweenMarkers = 1;
    public int totalMarkers = 120;
    private float numberOfMarkers = 0;

    private bool inGame = false;
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (inGame)
        {
            m_horizontalInput = Input.GetAxisRaw("Horizontal");
            m_verticalInput = Input.GetAxisRaw("Vertical");

            timer += Time.deltaTime;

            if (timer > timeBetweenMarkers)
            {
                timer = 0;
                GameObject footStep = Instantiate(markerSample);

                if (numberOfMarkers > totalMarkers)
                {
                    numberOfMarkers = totalMarkers;
                }
                footStep.GetComponent<SpriteRenderer>().color = new Color(numberOfMarkers / totalMarkers, (1 - numberOfMarkers / totalMarkers), (1 - numberOfMarkers / totalMarkers));
                numberOfMarkers++;
                footStep.transform.position = new Vector3(transform.position.x, transform.position.y, -1);
            }

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
    }

    private void FixedUpdate()
    {
        m_rigidBody.velocity = new Vector2(m_horizontalInput * m_runSpeed, m_verticalInput * m_runSpeed);
    }

    public void setInGame(bool _inGame)
    {
        inGame = _inGame;
    }
}
