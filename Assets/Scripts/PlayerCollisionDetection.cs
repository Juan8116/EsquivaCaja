using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    
    public TiempoManager tiempoManager; // asignalo en el Inspector

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Caja"))
        {
            tiempoManager.PausarTiempo(); // 👈 pausa antes de destruir
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
