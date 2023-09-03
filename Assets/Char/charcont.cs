using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcont : MonoBehaviour
{
    public GameObject character;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("crouch"))
        {
            character.GetComponent<Animator>().Play("Crouching");
        }
        if (Input.GetButtonDown("run"))
        {
            character.GetComponent<Animator>().Play("Fast Run");
        }
        if (Input.GetButtonDown("burpee"))
        {
            character.GetComponent<Animator>().Play("Burpee");
        }
    }
}