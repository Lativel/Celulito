using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.EnhancedTouch;
public class TouchManager : MonoBehaviour
{
   
    [SerializeField] GameObject Objeto;
    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }
    private void OnDisable()
    {
        EnhancedTouchSupport.Disable();

    }

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

