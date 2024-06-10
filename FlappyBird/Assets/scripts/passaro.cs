using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3;

    //cria a variavel fisica do tipo Rigidbody
    Rigidbody2D fisica;

    //m�todo Awake � chamado toda vez que o objeto � criado
    private void Awake()
    {
        //adiciona � variavel f�sica o componente RigidBody daquele objeto ativo no momento
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
    //m�todos private somente nossa classe pode acessar
    private void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicou");
            //chama o m�todo impulsionar
            //o this serve para indicar que � o objeto ativo naquele momento que recer� a��o
            this.Impulsionar();
        }
    }
    //m�todo que impulsiona nosso p�ssaro
    private void Impulsionar()
    {
        //adiciona a vari�vel f�sica e o m�todo AddForce, adicionando uma for�a para cima do tipo impulso
        this.fisica.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);
    }
}