using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class catfood : MonoBehaviour
{
    public static bool cat_food = false;
    public static bool audiotrigger = false;
    public Transform other;
    public GameObject textbox;
    public GameObject foodimg;
    public GameObject catfoodimg;
    //private bool epressed = false;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cat_food == false){
            float dist = Vector2.Distance(other.position, transform.position);
            if (dist <= 1.8){
                if(Input.GetKey(KeyCode.E)){
                    textbox.SetActive(true);
                    audiotrigger = true;
                    text.text = "That's my cat's favorite food!";
                    catfoodimg.SetActive(true);
                    foodimg.SetActive(true);
                    StartCoroutine(textwait());
                }
            }
            else{
                textbox.SetActive(false);
            }
        }  

        IEnumerator textwait()
        {
            yield return new WaitForSeconds(4.0f);
            cat_food = true;
            text.text = "";
            textbox.SetActive(false);
        }
    }
}
