using UnityEngine;

namespace Extensions
{
    public static class MonoBehaviourExtensions
    {
        public static void Activate(this MonoBehaviour monoBehaviour)
        {
            monoBehaviour.monoBehaviour.SetActive(true);
        }
        
        public static void Deactivate(this MonoBehaviour monoBehaviour)
        {
            monoBehaviour.gameObject.SetActive(false);
        }
        
        public static void Enable(this MonoBehaviour monoBehaviour)
        {
            monoBehaviour.enable = true;
        }
        
        public static void Disable(this MonoBehaviour monoBehaviour)
        {
            monoBehaviour.enabled = false;
        }
    }
}