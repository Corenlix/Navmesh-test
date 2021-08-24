using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameState : MonoBehaviour
    {
        [SerializeField] private GameObject finishGamePanel;

        public void Finish()
        {
            Time.timeScale = 0;
            finishGamePanel.SetActive(true);
        }

        public void Restart()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
