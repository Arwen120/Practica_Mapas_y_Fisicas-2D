using UnityEngine;

public class MascotaPeligrosa2D : MonoBehaviour
{
    public int puntosPerdidos = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PuntuacionJugador puntuacion = other.GetComponent<PuntuacionJugador>();

        if (puntuacion != null)
        {
            puntuacion.ModificarPuntos(-puntosPerdidos);
        }
    }
}