    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ControlAnimus : MonoBehaviour
    {

        [SerializeField] Animator anim;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        int index = -1;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                switch (index) {
                    case 0: anim.Play("Can Can");
                        break;
                    case 1:
                        anim.Play("House Dance");
                        break;
                    case 2:
                        anim.Play("Tut Hip Hop");
                        break;

                }
                index++;
                index = index % 3;
            }
        }
    }
