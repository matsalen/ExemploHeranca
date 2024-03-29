﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] protected string nome;
    protected float velocidadeVertical;

    Vector3 posicaoInicial;
    Vector3 posicao;

    private void Start()
    {
        posicaoInicial = transform.position;
    }

    private void Update()
    {
        Move();
    }
    protected virtual void Move()
    {
        posicao = posicaoInicial + Vector3.right * Mathf.Sin(Time.time);

        if (velocidadeVertical > 0)
            velocidadeVertical -= 5 * Time.deltaTime;
        else if (velocidadeVertical < 0) 
            velocidadeVertical = 0;


        posicao.y = velocidadeVertical + posicao.y;
        transform.position = posicao;
    }

    protected virtual void Fala()
    {
        Debug.Log("O animal diz: Bem-vindo");
    }

    protected virtual void Pula()
    {
        velocidadeVertical = 2.0f;
    }
}
