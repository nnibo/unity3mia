using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 2f;

    [SerializeField]
    private float variacaoPosicaoY;
    private Vector3 posicaoPassaro;
    private bool pontuei;
    private UiController controladorUI;
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }

    private void Start()
    {
        this.controladorUI = GameObject.FindObjectOfType<UiController>();
        this.posicaoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime );
        if(!this.pontuei && this.transform.position.x < this.posicaoPassaro.x)
        {
            this.controladorUI.adicionarPontos();
            this.pontuei = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }
    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}
