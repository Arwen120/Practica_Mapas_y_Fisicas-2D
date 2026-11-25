using UnityEngine;

public class Recolectable2D : MonoBehaviour
{
    public int puntosGanados = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PuntuacionJugador puntuacion = other.GetComponent<PuntuacionJugador>();

        if (puntuacion != null)
        {
            puntuacion.ModificarPuntos(puntosGanados);
            Destroy(gameObject);
        }
    }
}