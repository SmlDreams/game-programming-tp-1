using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    void Start()
    {
        // Trouver le bouton dans la scène
        Button btn = GetComponent<Button>();

        // Ajouter une fonction de rappel au clic du bouton
        btn.onClick.AddListener(QuitGame);
    }

    void QuitGame()
    {
        // Quitter le jeu
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}

