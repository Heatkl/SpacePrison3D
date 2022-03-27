using UnityEngine;
using UnityEngine.SceneManagement;

public class Load3 : MonoBehaviour
{
   public void loadNext()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Level3");
    }
}
