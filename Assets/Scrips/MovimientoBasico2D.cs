using UnityEngine;

public class MovimientoBasico2D : MonoBehaviour
{
    public float velocidad = 5f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        transform.Translate(
            new Vector3(movimientoHorizontal, movimientoVertical, 0)
            * velocidad * Time.deltaTime
        );

        if (movimientoHorizontal > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movimientoHorizontal < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}