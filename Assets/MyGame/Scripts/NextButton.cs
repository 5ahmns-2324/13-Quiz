using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SzeneWechselScript : MonoBehaviour
{
    public Button weiterButton;

    // Wird aufgerufen, wenn das Script gestartet wird.
    void Start()
    {
        // Füge dem Button die entsprechende Funktion hinzu.
        weiterButton.onClick.AddListener(WeiterButton);
    }

    void WeiterButton()
    {
        Debug.Log("Weiter Button wurde aktiviert!");

        // Erhalte den Index der aktuellen Szene.
        int aktuelleSzeneIndex = SceneManager.GetActiveScene().buildIndex;

        // Lade die nächste Szene basierend auf dem Index.
        SceneManager.LoadScene(aktuelleSzeneIndex + 1);
    }

  
}
