using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class catdesc : MonoBehaviour
{
    public Transform other;
    public GameObject textbox;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist_cat = Vector2.Distance(other.position, transform.position);
        if (dist_cat <= 2){
            if(Input.GetKey(KeyCode.E)){
                textbox.SetActive(true);
                text.text = "He's my little cat. I trully truly love him. ";
                StartCoroutine(catdesc());
            }
        }
        else{
            textbox.SetActive(false);
        }

        IEnumerator catdesc(){
            yield return new WaitForSeconds(4.0f);
            text.text = "";
            textbox.SetActive(false);
        }
    }
}
