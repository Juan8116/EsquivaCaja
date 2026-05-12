using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{

    public float velocidadCaja = 2f;
    float initialYValue;
    // Start is called before the first frame update
    void Start()
    {
        initialYValue = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-velocidadCaja * Time.deltaTime,0);
    }
    public void MoveBoxToRandomPosition()
    {
        Vector3 newPosition = transform.position;
        int randomX = 0;
        randomX = Random.Range(0,3);
        if(randomX == 0){
            newPosition.x = -2;
        } else if(randomX == 1){
            newPosition.x = 0;
        } else{
            newPosition.x = 2;
        }
        newPosition.y = initialYValue;
        
        transform.position = newPosition;
    }
    // CajaMovement.cs - Agregá este método público
public void IncrementarVelocidad(float incremento = 0.5f)
{
    velocidadCaja += incremento;
}
}
