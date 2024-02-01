using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AntwortScript : MonoBehaviour
{
    public Button richtigeAntwortButton;
    public Button falscheAntwortButton;
    public Button neuerButton;

    private bool richtigeAntwortGewaehlt = false;


    void Start()
    {

        richtigeAntwortButton.onClick.AddListener(RichtigeAntwort);
        falscheAntwortButton.onClick.AddListener(FalscheAntwort);
        neuerButton.onClick.AddListener(NeuerButton);
    }

    void RichtigeAntwort()
    {
        Debug.Log("Richtige Antwort!");
    
        richtigeAntwortButton.image.color = Color.green;
  
        richtigeAntwortGewaehlt = true;

    }

    void FalscheAntwort()
    {
        Debug.Log("Falsche Antwort!");
  
        falscheAntwortButton.image.color = Color.red;
     
    }

    void NeuerButton()
    {

        if (richtigeAntwortGewaehlt)
        {
            Debug.Log("Neuer Button wurde aktiviert!");
       

         
        }
        else
        {
            Debug.Log("Wähle zuerst die richtige Antwort!");
   
        }
    }
}