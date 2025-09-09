using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem.LowLevel;
public class TouchManager : MonoBehaviour
{

    [SerializeField]
    private GameObject targetObject;
    private bool canMove = true;

    void Update()
    {
        if (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.isPressed)
        {         
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();

            Ray touchRay = Camera.main.ScreenPointToRay(touchPosition);

            targetObject.transform.position = touchRay.GetPoint(1f);
        }
    }
    public void StopMoving()
    {
        canMove = false;
        Debug.Log("Movimiento detenido.");
    }

}

