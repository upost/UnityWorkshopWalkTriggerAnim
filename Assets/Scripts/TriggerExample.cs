using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    public GameObject animatedCharacter;
    public string animationToPlay;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter collider " + other);
        Animation a = animatedCharacter.GetComponent<Animation>();
        a.Play(animationToPlay);
       
    }

}
