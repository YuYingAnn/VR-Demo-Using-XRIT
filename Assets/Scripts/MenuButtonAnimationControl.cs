using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class MenuButtonAnimationControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animObj;
    public void isMainButtonHovered(bool hoverBool)
    {
        animObj.SetBool("isHovered", hoverBool);
    }
    public void isMainButtonPressed(bool pressedBool)
    {
        if(pressedBool)
        {
            animObj.transform.Find("Outline").GetComponent<Image>().color = Color.yellow;
        }
        else
        {
            animObj.transform.Find("Outline").GetComponent<Image>().color = Color.white;
        }
    }
    public void AuidoMenuOpen()
    {
        //animObj.SetTrigger("PanelClose");
        animObj.SetTrigger("AudioOpen");
    }
    public void ToolboxMenuOpen()
    {
        //animObj.SetTrigger("PanelClose");
        animObj.SetTrigger("ToolboxOpen");
    }
    public void CloseCurrentPanel()
    {
        animObj.SetTrigger("PanelClose");
    }
}
