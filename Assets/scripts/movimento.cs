using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    //variável da velocidade do personagem
    [SerializeField] protected int velocidade = 5;

    //variáveis dos "inputs" (controles/botões) que nosso jogador está apertando
    float inputVertical;
    float inputHorizontal;


    void Start()
    {
        
    }

    void Update()
    {
        //Detecta os controles e assimila eles às variáveis
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical   = Input.GetAxis("Vertical");

        //Aqui move o personagem
        transform.Translate(Vector3.forward * Time.deltaTime * velocidade * inputVertical);
        transform.Translate(Vector3.right   * Time.deltaTime * velocidade * inputHorizontal);

    }
}
