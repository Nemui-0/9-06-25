using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    public Rigidbody2D rb;
    public Vector2 entrada;
    private Animator animator;

    [SerializeField] private InputAction movimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void OnEnable()
    {
        movimiento.Enable();
        movimiento.performed += Moverse;
        movimiento.canceled += Moverse;
    }

    void OnDisable()
    {
        movimiento.performed -= Moverse;
        movimiento.canceled -= Moverse;
        movimiento.Disable();
    }

    void Update()
    {
        rb.linearVelocity = entrada * velocidad;
    }

    private void Moverse(InputAction.CallbackContext contexto)
    {
        Vector2 valorEntrada = contexto.ReadValue<Vector2>();

        // Determinar el eje dominante
        if (Mathf.Abs(valorEntrada.x) > Mathf.Abs(valorEntrada.y))
        {
            entrada = new Vector2(Mathf.Sign(valorEntrada.x), 0);
        }
        else if (Mathf.Abs(valorEntrada.y) > 0)
        {
            entrada = new Vector2(0, Mathf.Sign(valorEntrada.y));
        }
        else
        {
            entrada = Vector2.zero;
        }

        // Animaciones
        animator.SetBool("estaCaminando", entrada != Vector2.zero);
        animator.SetFloat("entradaX", entrada.x);
        animator.SetFloat("entradaY", entrada.y);
    }
}
