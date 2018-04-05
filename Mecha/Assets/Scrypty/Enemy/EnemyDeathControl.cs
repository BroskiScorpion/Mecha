using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathControl : DeathControl {

    public new void Death()
    {
        Destroy(this.gameObject);
    }

}
