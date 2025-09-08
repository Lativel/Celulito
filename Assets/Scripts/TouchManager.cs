using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.EnhancedTouch;
public class TouchManager : MonoBehaviour
{
   
    [SerializeField] GameObject Objeto;

     void Update()
     {
      if(Touchscreen.current.touches.Count > 0)
        {
            UnityEngine.InputSystem.EnhancedTouch.Touch touchone;
            touchone = UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches[0];

            Ray rayo = Camera.main.ScreenPointToRay(touchone.screenPosition);
            Objeto.transform.position = rayo.origin + (rayo.direction * 1);
        }


     }
   
}

