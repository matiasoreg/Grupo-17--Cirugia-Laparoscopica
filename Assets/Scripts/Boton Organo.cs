using UnityEngine;

public class ControlOrgano : MonoBehaviour
{
    // Aquí conectaremos el órgano desde el Inspector
    public GameObject organo;

    // Esta función alternará el estado de visibilidad
    public void AlternarVisibilidad()
    {
        if (organo != null)
        {
            // Cambia el estado al contrario del que tiene actualmente
            organo.SetActive(!organo.activeSelf);
        }
    }
}