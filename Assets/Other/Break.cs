using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    [SerializeField]
    Sprite BrokeTexture;
    [SerializeField]
    GameObject Pieces;
    public float Damage
    {
        get { return _damageAmount; }
        set
        {
            _damageAmount = value;
            if (_damageAmount <= 50 && this.GetComponent<SpriteRenderer>().sprite != BrokeTexture)
            {
                this.GetComponent<SpriteRenderer>().sprite = BrokeTexture;
            }
            if (_damageAmount <= 0)
            {
                Instantiate(Pieces, this.transform.position, Quaternion.Euler(0, 0, 0));
                Destroy(this.gameObject);
            }
        }
    }
    float _damageAmount = 100f;
}
