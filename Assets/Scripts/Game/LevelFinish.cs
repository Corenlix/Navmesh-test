using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Collider))]
    public class LevelFinish : MonoBehaviour
    {
        [SerializeField] private GameState gameState;
        
        private void OnTriggerEnter(Collider other)
        {
            gameState.Finish();
        }
    }
}
