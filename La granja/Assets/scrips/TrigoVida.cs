using UnityEngine;
using UnityEngine.inputSystem
using System.Collections

public class TrigoVida : MonoBehaviour
 
{
    int Estado;
    Animator animator;
    float tiempo = 5f;

    void Start()
    {
                animator = GetComponet<Animator>();
                Start.Coroutine(CambiarEstado());
    }

    private IEnumerator CambiarEstado(){
        while(estadoTrigo < 4){
            animator.Setlntrger("estado",estadoTrigo)
            estadoTrigo++;
            yield return new WaitForSeconds(tiempo);

 }
        
    }
}
