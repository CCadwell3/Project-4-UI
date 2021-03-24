using UnityEngine;

public class DamagePickup : Pickups
{
    [SerializeField, Tooltip("How much damage to apply")]
    private float damage = 25;

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void OnPickup(Player player)
    {
        player.health.Damage(damage);
        base.OnPickup(player);
    }
}