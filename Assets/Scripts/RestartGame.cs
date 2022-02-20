using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public static void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
