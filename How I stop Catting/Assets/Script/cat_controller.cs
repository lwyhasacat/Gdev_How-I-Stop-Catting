using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_controller : MonoBehaviour
{
    private Animator cat_ani;
    public static float movementSpeed = 0.01f;
    private bool nextmove = false;
    public Transform other;
    private bool catwait = false;
    public static float ypos;
    private bool checkani = false;
    private bool checkaniagain = false;
    public static bool candy = false;

    // Start is called before the first frame update
    void Start()
    {
        cat_ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ypos = transform.position.y;

        if(catfood.cat_food == true && catwait == false){
            cat_ani.SetBool("cat_up", true);
            StartCoroutine(cat());
            if(nextmove == true){
                transform.Translate(-1 * movementSpeed, 0, 0);
                float dist = Vector2.Distance(other.position, transform.position);
                if(dist < 1){
                    movementSpeed = 0;
                    catwait = true;
                }
            }
            else{
                nextmove = false;
            }
        }
        IEnumerator cat(){
            yield return new WaitForSeconds(1.0f);
            nextmove = true;
        }

        if(catwait == true && checkani == false){
            cat_ani.SetBool("cat_at_desk", true);
            if(movetodesk.foodontable == true){
                movementSpeed = 0.02f;
                cat_ani.SetBool("food_on_table", true);
                if(ypos < 1.2){
                    transform.Translate(0, movementSpeed, 0);
                }
                if(ypos >= 1.2){
                    checkani = true;
                    cat_ani.SetBool("food_on_table", false);
                }
            }
        }

        if(checkani == true && lighton.light_on == true){
            movementSpeed = 0.02f;
            cat_ani.SetBool("food_on_table", true);
            if(ypos < 2.6){
                transform.Translate(-1.5f * movementSpeed, movementSpeed, 0);
            }
            if(ypos >= 2.6){
                checkani = true;
                cat_ani.SetBool("food_on_table", false);
                StartCoroutine(waitcat());
            }

            IEnumerator waitcat(){
                yield return new WaitForSeconds(1.0f);
                checkaniagain = true;
            }
            
            if(checkaniagain == true){
                movementSpeed = 0.02f;
                cat_ani.SetBool("food_on_table", true);
                if(ypos < 4.0){
                    transform.Translate(-1.2f * movementSpeed, movementSpeed, 0);
                }
                if(ypos >= 4.0){
                    cat_ani.SetBool("food_on_table", false);
                    checkaniagain = false;
                    StartCoroutine(waitcatagain());
                }
            }

            IEnumerator waitcatagain(){
                yield return new WaitForSeconds(1.0f);
                candy = true;
            }
        }
    }
}
