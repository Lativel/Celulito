using UnityEditor.Hardware;
using UnityEngine;

public class Detection : MonoBehaviour
{
    [SerializeField]GameObject OnjetoA;
    GameObject OnjetoB;
    void Update()
    {
        if (OnjetoA.transform.position == OnjetoB.transform.position)
        {
            Debug.Log(OnjetoA + "Dispositivo USB conectado");

        }
        else if (OnjetoA.transform.position != OnjetoB.transform.position);
        {
            Debug.Log( "No se detecta dispositivo");
        }

    }
}
