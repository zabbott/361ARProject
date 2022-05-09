using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour
{
    public void expand()
    {
        UIManager.Instance.Anim.SetTrigger("ShouldExpand");
    }

    public void shrink()
    {
        UIManager.Instance.Anim.SetTrigger("ShouldShrink");
    }

}
