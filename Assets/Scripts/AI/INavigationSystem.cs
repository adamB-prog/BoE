using UnityEngine;

namespace AI
{
    public interface INavigationSystem
    {
        public void ChangeTarget(GameObject obj);
        public GameObject GetTarget();
    }
}