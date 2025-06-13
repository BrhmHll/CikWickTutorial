using UnityEngine;

public class HolyWheatCollectible : BaseWheatCollectible
{
    [SerializeField] private float _forceIncrease;

    public override void Collect()
    {
        _playerController.SetJumpForce(_forceIncrease, _resetBoostDuration);
        base.Collect();
    }
}
