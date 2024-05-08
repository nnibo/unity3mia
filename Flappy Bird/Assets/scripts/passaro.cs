using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class passaro : MonoBehaviour
{
    Rigidbody2D fisica;

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            this.Impulsionar();
        } 
    }

    void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
    }
}




