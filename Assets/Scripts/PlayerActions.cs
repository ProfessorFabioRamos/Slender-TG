using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public int objsQt = 0;
    public GameObject feedbackPanel;

    // Start is called before the first frame update
    void Start()
    {
        feedbackPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Collectible"){
            //Debug.Log("CAVEIRA!");
            //objsQt = objsQt+1;
            //objsQt+=1;
            objsQt++;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Gun"){
            feedbackPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Gun"){
            feedbackPanel.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other){
        if(other.gameObject.tag == "Gun"){
            if(Input.GetKey(KeyCode.E)){
                Destroy(other.gameObject);
                feedbackPanel.SetActive(false);
            }
        }
    }
}
