using UnityEngine;

namespace Game
{
    public class CameraFollowingTarget : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float moveSpeed;
        [SerializeField] private Vector3 offset;
        
        private void Update()
        {
            transform.position = Vector3.Lerp(transform.position, target.position + offset, moveSpeed * Time.deltaTime);
        }
    }
}
