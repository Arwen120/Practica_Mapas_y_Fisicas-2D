using UnityEngine;

public class PuntuacionJugador : MonoBehaviour
{
    public int puntos = 0;

    public void ModificarPuntos(int cantidad)
    {
        puntos += cantidad;

        Debug.Log("Puntuación actual: " + puntos);
    }
}