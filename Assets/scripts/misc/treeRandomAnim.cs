using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeRandomAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomAnim = Random.Range(0, 2);
        Animation anim = GetComponent<Animation>();
        anim.Play("tree_idle" + randomAnim.ToString());
        float animSpeed = Random.Range(.3f, .75f);
        anim["tree_idle" + randomAnim.ToString()].speed = animSpeed;

    }

}
