using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlBotones2 : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] Animator anim2;

    [SerializeField] GameObject pepsiman;
    [SerializeField] GameObject lataPepsi;
    [SerializeField] GameObject ryder;

    [SerializeField] TextMeshProUGUI texto_rotador;
    [SerializeField] AudioSource audio;


    private int index = -1;
    private bool isObject1Active = true; 

    private Quaternion pepsimanInitialRotation = Quaternion.Euler(272.341431f, 221.132675f, 318.891022f);

    [SerializeField] Transform SpawnLataPepsi;


    private float impactForce = 10f; 
    private Vector3 impactDirection = new Vector3(-1, 1, 0);


    void Update()
    {
        
        if (index == 2)
        {
            pepsiman.transform.Rotate(0, 50 * Time.deltaTime, 0);   
            lataPepsi.transform.Rotate(0, 50 * Time.deltaTime, 0); //Y
            texto_rotador.rectTransform.Rotate(0, 0, 50 * Time.deltaTime, 0);
        }
    }

    void Start()
    {
        ryder.SetActive(false);
    }

    public void PlayAnimation(int animationIndex)
    {
        if (audio.isPlaying && animationIndex != 2)
        {
            pepsiman.transform.rotation = pepsimanInitialRotation;
            lataPepsi.transform.rotation = Quaternion.identity;
            texto_rotador.rectTransform.eulerAngles = Vector3.zero;
            audio.Stop();
        }

        switch (animationIndex)
        {
            case 0:
                anim2.Play("Pain Gesture");
                ryder.SetActive(true);
                lataPepsi.SetActive(true);
                pepsiman.SetActive(false);

                

                Invoke("LaunchPepsiCan", 3f);

                /* pepsiman.transform.rotation = pepsimanInitialRotation;
                 lataPepsi.transform.rotation = Quaternion.identity;
                 texto_rotador.rectTransform.eulerAngles = Vector3.zero;*/

                break;

            case 1:
                anim.Play("Can Can");

                pepsiman.SetActive(true);
                lataPepsi.SetActive(true);

                ResetPepsiCan();

                /* pepsiman.transform.rotation = pepsimanInitialRotation;
                 lataPepsi.transform.rotation = Quaternion.identity;
                 texto_rotador.rectTransform.eulerAngles = Vector3.zero;*/


                if (isObject1Active)
                {
                    pepsiman.SetActive(false);
                    lataPepsi.SetActive(true);
                }
                else
                {
                    pepsiman.SetActive(true);
                    lataPepsi.SetActive(false);
                }
                isObject1Active = !isObject1Active;

                ryder.SetActive(false);
               // lataPepsi.transform.position = new Vector3(-0.839999974f, 0.472000003f, -0.654417932f);
                break;

            case 2:
                anim.Play("Tut Hip Hop");

                

                pepsiman.SetActive(true);
                lataPepsi.SetActive(true);

                ResetPepsiCan();

                texto_rotador.gameObject.SetActive(true);

                if (!audio.isPlaying)
                {
                    audio.Play();
                }

                ryder.SetActive(false);
                //lataPepsi.transform.position = new Vector3(-0.839999974f, 0.472000003f, -0.654417932f);
                break;
        }

        index = animationIndex;
    }

    private void LaunchPepsiCan()
    {
        Rigidbody lataRigidbody = lataPepsi.GetComponent<Rigidbody>();
        if (lataRigidbody != null)
        {
            lataRigidbody.isKinematic = false; //Es para poder salir volando
            lataRigidbody.useGravity = true;

            lataRigidbody.AddForce(impactDirection.normalized * impactForce, ForceMode.Impulse);
        }
    }

    private void ResetPepsiCan()
    {
        Rigidbody lataRigidbody = lataPepsi.GetComponent<Rigidbody>();
        if (lataRigidbody != null)
        {
            lataRigidbody.isKinematic = false;
            lataRigidbody.useGravity = false; // Sin esto se cae al vacio
            lataRigidbody.velocity = Vector3.zero;
            lataRigidbody.angularVelocity = Vector3.zero;
        }

        // Teletransportar la lata al punto inicial
        lataPepsi.transform.position = SpawnLataPepsi.position;
        lataPepsi.transform.rotation = Quaternion.identity;

        lataPepsi.SetActive(true);
    }
    }
 