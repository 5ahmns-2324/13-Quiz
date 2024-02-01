using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    public int countdownSeconds = 15;
    public Text countdownText;

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        Debug.Log("Countdown startet!");

        for (int i = countdownSeconds; i >= 0; i--)
        {
            countdownText.text = $"{i}";
            yield return new WaitForSeconds(1f); 
        }

        Debug.Log("Countdown abgeschlossen!");
        countdownText.text = "Countdown abgeschlossen!";
    }
}