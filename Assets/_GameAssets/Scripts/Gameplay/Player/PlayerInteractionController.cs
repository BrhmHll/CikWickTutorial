using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Consts.WheatTypes.GOLD_WHEAT)
        || other.CompareTag(Consts.WheatTypes.HOLY_WHEAT)
        || other.CompareTag(Consts.WheatTypes.ROTTEN_WHEAT))
        {
            other.gameObject?.GetComponent<BaseWheatCollectible>().Collect();
        }
    }
}
