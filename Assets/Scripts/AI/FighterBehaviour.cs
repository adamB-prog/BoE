using UnityEngine;

namespace AI
{
    public enum Side
    {
        Rebel,
        Empire
    }
    public class FighterBehaviour : MonoBehaviour
    {
        [SerializeField] private Side side;

        [SerializeField] private float health;

        private INavigationSystem navigationSystem;

        [SerializeField]
        private GameObject testTarget;

        void Start()
        {
            navigationSystem = GetComponent<INavigationSystem>();
        }
        void FixedUpdate()
        {
            if (!navigationSystem.GetTarget().Equals(testTarget))
            {
                navigationSystem.ChangeTarget(testTarget);
            }
        }
    }
}