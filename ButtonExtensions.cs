using UnityEngine.Events;
using UnityEngine.UI;

namespace ErgonomicExtensions
{
    public static class ButtonExtensions
    {
        public static void Bind(this Button button, UnityAction call)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(call);
        }
    }
}