using UnityEngine;

public class PerseguirJugador2D : MonoBehaviour
{
    public Transform jugador;
    public float velocidad = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (jugador != null)
        {
            Vector2 direccion = ((Vector2)jugador.position - rb.position).normalized;

            rb.MovePosition(rb.position + direccion * velocidad * Time.fixedDeltaTime);
        }
    }
}