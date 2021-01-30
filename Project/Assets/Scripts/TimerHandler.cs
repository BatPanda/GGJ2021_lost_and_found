using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerHandler : MonoBehaviour
{
    [SerializeField] private Image m_coutdownImage = default;
    [SerializeField] private TextMeshProUGUI m_countdownText = default;

    [SerializeField] private int m_secondsUntilGameOver = 120;
    public UnityEvent OnGameOver;

    private int m_secondsLeft;

    private void Awake()
    {
        m_secondsLeft = m_secondsUntilGameOver;
        UpdateDisplay();

        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            m_secondsLeft--;
            UpdateDisplay();

            if (m_secondsLeft <= 0)
            {
                OnGameOver.Invoke();
                break;
            }
        }
    }

    private void UpdateDisplay()
    {
        m_countdownText.text = $"{(m_secondsLeft / 60).ToString("00")}:{(m_secondsLeft % 60).ToString("00")}";
        m_coutdownImage.fillAmount = m_secondsLeft / (float)m_secondsUntilGameOver;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
