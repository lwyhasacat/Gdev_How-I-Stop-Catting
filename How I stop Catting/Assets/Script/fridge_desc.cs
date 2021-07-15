using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fridge_desc : MonoBehaviour
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
        float dist_fridge = Vector2.Distance(other.position, transform.position);
        if (dist_fridge <= 3){
            if(Input.GetKey(KeyCode.E)){
                textbox.SetActive(true);
                text.text = "These are drawings of my cat.";
                StartCoroutine(desc());
            }
        }
        else{
            textbox.SetActive(false);
        }

        IEnumerator desc(){
            yield return new WaitForSeconds(4.0f);
            text.text = "";
            textbox.SetActive(false);
        }
    }
}
