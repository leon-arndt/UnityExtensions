using UnityEngine;

namespace ErgonomicExtensions
{
    public static class GameObjectExtensions
    {
        public static void Activate(this GameObject gameObject)
        {
            gameObject.SetActive(true);
        }
        
        public static void Deactivate(this GameObject gameObject)
        {
            gameObject.SetActive(false);
        }
        
        public static void ToggleActive(this GameObject gameObject)
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}