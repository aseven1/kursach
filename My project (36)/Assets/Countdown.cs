using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdownText;
    private int countdown = 5;

    void Start()
    {
        InvokeRepeating("UpdateCountdown", 0f, 1f); // обновление каждую секунду
    }

    void UpdateCountdown()
    {
        if (countdown > 0)
        {
            countdownText.text = countdown.ToString();
            countdown--;
        }
        else
        {
            countdownText.text = "ПУСК";
            CancelInvoke("UpdateCountdown"); // остановка обратного отсчёта
        }
    }
}