using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class GameStarter : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene(SceneName.Game);
        }
    }
}
