using UnityEngine;

public abstract class BaseWheatCollectible : MonoBehaviour
{
    [SerializeField] protected PlayerController _playerController;
    [SerializeField] protected float _resetBoostDuration;

    public virtual void Collect()
    {
        Destroy(gameObject);
    }
}
