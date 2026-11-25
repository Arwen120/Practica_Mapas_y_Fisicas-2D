using UnityEngine;

public class Lanzador2D : MonoBehaviour
{
    public Vector2 direccion = new Vector2(1, 1);
    public float fuerza = 8f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("¡Algo ha entrado en el lanzador!");

        Rigidbody2D rb = other.attachedRigidbody;

        if (rb != null)
        {
            rb.AddForce(direccion.normalized * fuerza, ForceMode2D.Impulse);
        }
    }
}