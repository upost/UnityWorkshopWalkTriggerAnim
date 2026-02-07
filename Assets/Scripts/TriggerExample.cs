using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    public GameObject animatedCharacter;
    public string animationToPlay;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter collider " + other);
        Animator a = animatedCharacter.GetComponent<Animator>();
        a.Play(animationToPlay);
       
    }

}
