using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private CharacterController controller;
    private float speed = 5.0f;
    public static bool gameover;

    public GameObject character;
    public int count;

    // Use this for initialization
    void Start() {
        
        gameover = false;
        count = 0;
        controller = GetComponent<CharacterController>();

    }

 
     // Update is called once per frame
     void Update ()
    {
        Debug.Log(gameover);
        if (gameover == false)
        {
            controller.Move((Vector3.back * speed) * Time.deltaTime);
           
        }
        if (gameover == true)
        {
            Debug.Log("gameover");
            // controller.Move((Vector3.back * speed) * Time.deltaTime);
        }



        if (Input.GetMouseButtonDown(0) && count ==0)
        {
            count = 1;

        }
        if(count==1)
        {
            character.GetComponent<Animator>().Play("characterMoveRight");
            count = 2;
        }
        if (Input.GetMouseButtonDown(0) && count == 2)
        {
            count = 3;
        }
        if (count == 3)
        {
            character.GetComponent<Animator>().Play("characterMoveLeft");
            count = 0;
        }
      

    }



}
