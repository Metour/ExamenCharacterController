using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public void speed = 0.5f;

    //public void jumpHeight = 1f;

    //private void jump;

    private float move;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Awake()
    {
        
    }

    float Move = GetAxisRaw<GameObject>("Vertical");
}
