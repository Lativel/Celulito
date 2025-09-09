using UnityEditor.Hardware;
using UnityEngine;

public class Detection : MonoBehaviour
{
   [SerializeField] TouchManager detection;

    private void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Player"))
        {
            if (detection != null)
            {
                detection.StopMoving();
            }
        }
    }
}
