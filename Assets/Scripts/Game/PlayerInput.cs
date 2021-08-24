using UnityEngine;

namespace Game
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private Mover playerMover;
        private Camera _mainCamera;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) &&
                Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                playerMover.Move(hit.point);
            }
        }
    }
}
