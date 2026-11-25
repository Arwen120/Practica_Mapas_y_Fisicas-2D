using UnityEngine;



public class RotacionYMovimientoLocal2D : MonoBehaviour
{
    public float velocidad = 5f;
    public float velocidadRotacion = 180f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, -horizontal * velocidadRotacion * Time.deltaTime);

        transform.Translate(
            Vector3.up * vertical * velocidad * Time.deltaTime,
            Space.Self
        );
    }
}