using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKeyToStart : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "GameScene"; 
    private bool isLoading = false;

    void Update()
    {
        if (!isLoading && Input.anyKeyDown)
        {
            isLoading = true;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}