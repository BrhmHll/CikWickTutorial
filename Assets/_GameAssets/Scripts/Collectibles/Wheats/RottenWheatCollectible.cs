using UnityEngine;

public class RottenWheatCollectible : BaseWheatCollectible
{
    [SerializeField] private float _movementDecreaseSpeed;

    public override void Collect()
    {
        _playerController.SetMovementSpeed(-_movementDecreaseSpeed, _resetBoostDuration);
        base.Collect();
    }
}
