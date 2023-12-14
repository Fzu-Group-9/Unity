using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShark : MonoBehaviour
{
    public Animator canAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shake()
    {
        canAnim.SetTrigger("Shake");
    }
}
