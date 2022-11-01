using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{

    void Show(Animator animator)
    {
        animator.SetBool("Visible", true);
    }

    void Hide(Animator animator)
    {
        animator.SetBool("Visible", false);
    }
}
