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
    public UnityEvent OnGameWon;


    private int m_secondsLeft;

    public bool ended = false;
    private void Awake()
    {
        m_secondsLeft = m_secondsUntilGameOver;
    }

    public int startTimer()
    {
        UpdateDisplay();
        StartCoroutine(UpdateTimer());
        return m_secondsUntilGameOver;
    }

    private IEnumerator UpdateTimer()
    {
        while (true && !ended)
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

    public void invokeWin(bool win)
    {
        if (win)
        {
            OnGameWon.Invoke();
        }
        else
        {
            OnGameOver.Invoke();
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
