using UnityEngine;
using UnityEngine.AI;

namespace Game
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class NavmeshMover : Mover
    {
        [SerializeField] private Animator animator;
        private NavMeshAgent _agent;
        private static readonly int SpeedAnimationId = Animator.StringToHash("Speed");

        public override void Move(Vector3 point)
        {
            _agent.SetDestination(point);
        }

        private void Update()
        {
            animator.SetFloat(SpeedAnimationId, _agent.velocity.magnitude/_agent.speed);
        }

        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
        }
    }
}