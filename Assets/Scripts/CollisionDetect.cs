using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    
    [SerializeField] GameObject thePlayer;
    [SerializeField] private GameObject playerAnim;
    void OnTriggerEnter(Collider other)
    {
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Armature_Armature_BeHit_FlyUp_baselayer");
    }
}
