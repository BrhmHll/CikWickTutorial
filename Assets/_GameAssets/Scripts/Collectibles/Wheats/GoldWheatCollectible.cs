using System.Runtime.CompilerServices;
using UnityEngine;

public class GoldWheatCollectible : BaseWheatCollectible
{
    [SerializeField] private float _movementIncreaseSpeed;

    public override void Collect()
    {
        _playerController.SetMovementSpeed(_movementIncreaseSpeed, _resetBoostDuration);
        base.Collect();
    }


}
