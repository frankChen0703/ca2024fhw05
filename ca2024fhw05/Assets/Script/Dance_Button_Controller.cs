using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dance_Button_Controller : MonoBehaviour
{

    public Button Dance_Button1;
    public Button Dance_Button2;
    public Button Dance_Button3;
    public GameObject Avatar;

    private Animator Avatar_Animator;

    // Start is called before the first frame update
    void Start()
    {
        Dance_Button1.onClick.AddListener(Dance_Button1_Click_Event);//call Dance_Button1_Click_Event() function when Chicken_Dance button clicked.
        Dance_Button2.onClick.AddListener(Dance_Button2_Click_Event);//call Dance_Button2_Click_Event() function when Shake_Hip_Hop_Dance button clicked.
        Dance_Button3.onClick.AddListener(Dance_Button3_Click_Event);//call Dance_Button3_Click_Event() function when jump button clicked.
        Avatar_Animator = Avatar.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Dance_Button1_Click_Event()
    {
        
        Avatar_Animator.SetTrigger("Chicken_Dance");
    }

    void Dance_Button2_Click_Event()
    {
        
        Avatar_Animator.SetTrigger("Shake_Hip_Hop_Dance");
    }

    void Dance_Button3_Click_Event()
    {
     
        Avatar_Animator.SetTrigger("Jump");
    }
}
