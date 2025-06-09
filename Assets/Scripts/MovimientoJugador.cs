using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    //variables
    private float velocidad = 5f;
    private Rigidbody2D rb;
    private Vector2 entrada;

    // Start es llamada cuando se inicia el script
    void Start()
    { // enlazar componentes
        rb = GetComponent<Rigidbody2D>();
    }

    // Update es llamada un vez por frame
    void Update()
    {
        rb.linearVelocity = entrada * velocidad;
    }

    // funciones creadas por nosotros
    public void Moverse(InputAction.CallbackContext contexto){
        
        entrada =  contexto.ReadValue<Vector2>();
        
    }

    
}
