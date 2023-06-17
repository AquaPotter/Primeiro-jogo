using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    //vari�vel da velocidade do personagem
    [SerializeField] protected int velocidade = 5;

    //vari�veis dos "inputs" (controles/bot�es) que nosso jogador est� apertando
    float inputVertical;
    float inputHorizontal;


    void Start()
    {
        
    }

    void Update()
    {
        //Detecta os controles e assimila eles �s vari�veis
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical   = Input.GetAxis("Vertical");

        //Aqui move o personagem
        transform.Translate(Vector3.forward * Time.deltaTime * velocidade * inputVertical);
        transform.Translate(Vector3.right   * Time.deltaTime * velocidade * inputHorizontal);

    }
}
