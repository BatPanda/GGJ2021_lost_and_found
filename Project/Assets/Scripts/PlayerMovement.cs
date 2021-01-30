using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_runSpeed = 20.0f;

    private Rigidbody2D m_rigidBody;

    private float m_horizontalInput;
    private float m_verticalInput;

    public GameObject markerSample;

    private float timer = 0;
    public float timeBetweenMarkers = 1;
    public int totalMarkers = 120;
    private float numberOfMarkers = 0;

    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
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
            footStep.GetComponent<SpriteRenderer>().color = new Color(numberOfMarkers / totalMarkers, (1 - numberOfMarkers/ totalMarkers), (1- numberOfMarkers / totalMarkers));
            numberOfMarkers++;
            footStep.transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        }
    }

    private void FixedUpdate()
    {
        m_rigidBody.velocity = new Vector2(m_horizontalInput * m_runSpeed, m_verticalInput * m_runSpeed);
    }
}
