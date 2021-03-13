using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPlayerPosition : MonoBehaviour
{
    [SerializeField] private GameObject playerGameObject;
    [SerializeField] private Transform playerStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        playerStartPosition = playerGameObject.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

}
