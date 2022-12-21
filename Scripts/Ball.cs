using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool isRight;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if(isRight){
            transform.Translate(speed * Time.deltaTime * Vector2.right);
        }else{
            transform.Translate(-speed * Time.deltaTime * Vector2.right);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isRight = !isRight;
        }
    }
}
