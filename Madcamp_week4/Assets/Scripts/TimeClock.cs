using UnityEngine;
using TMPro;

public class TimeClock : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeRemaining = 90; // 타이머 시작 시간 (초)

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        // 타이머 값을 정수로 변환하여 표시
        timerText.text = Mathf.RoundToInt(timeRemaining).ToString();
    }
}