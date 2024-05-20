using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundoMovimento : MonoBehaviour
{
    [SerializeField]
    private float movimento = 2;
    private Vector3 posicaoInicial;
    private float tamanhoDaImagemNaCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagemOriginal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoDaImagemNaCena = tamanhoDaImagemOriginal * escala;
    }
    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.movimento * Time.time, tamanhoDaImagemNaCena);
        this.transform.position = this.posicaoInicial + (Vector3.left * deslocamento);
    }
}
