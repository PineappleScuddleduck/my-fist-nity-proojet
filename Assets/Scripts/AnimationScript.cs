using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public Player player;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (player.superJumpsRemaining == 0) 
            {
               anim.Play("JumpAnimation", -1, 0f); 
            }
            else if (player.superJumpsRemaining > 0) 
            {
                anim.Play("1BeegJumpAnimation", -1, 0f);
            }
        }
            if (Input.GetKeyDown(KeyCode.A)) 
            {
                transform.Rotate(Vector3.up * -180);
            }
            if (Input.GetKeyDown(KeyCode.D)) 
            {
                transform.Rotate(Vector3.up * -180);
            }
    }

}