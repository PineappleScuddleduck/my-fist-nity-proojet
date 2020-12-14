using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Endscrn;
    [SerializeField] private GameObject StopObject;

    private void OnTriggerEnter(Collider other)   
    {
        if(other.gameObject.tag == "Player")  
        {
            Endscrn.gameObject.SetActive(true);
            StopObject.gameObject.SetActive(true);
        }
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Return)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}
