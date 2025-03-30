using UnityEngine;

public class CollectCion : MonoBehaviour
{
    [SerializeField] AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        MasterInfo.coinCount += 1;
        this.gameObject.SetActive(false);
    }

}
