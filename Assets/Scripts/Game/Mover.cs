using UnityEngine;

namespace Game
{
    public abstract class Mover : MonoBehaviour
    {
        public abstract void Move(Vector3 point);
    }
}
