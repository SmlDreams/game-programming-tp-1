using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    // Le nom de la scène à charger
    public string sceneToLoad;

    void Start()
    {
        Button btn = GetComponent<Button>();

        btn.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
