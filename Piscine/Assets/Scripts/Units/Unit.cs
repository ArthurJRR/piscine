using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    protected string unitName;
    public int hp;
    public int atk;
    protected SpriteRenderer sprite;
    protected Animator animator;
    protected string proprietaire;
    //private Joueur proprietaire; //TODO à coder plus tard


	// Use this for initialization
	void Start () {
        Debug.Log("I'm here !");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setSprite(SpriteRenderer _sprite)
    {
        this.sprite = _sprite;
    }

    public void setAnimator(Animator anim)
    {
        this.animator = anim;
    }

    public string getProprio()
    {
        return proprietaire;
    }

    public void SetHp(int health)
    {
        this.hp = health;
    }

    public int GetHp()
    {
        return hp;
    }

    public void SetAtk(int atk)
    {
        this.atk = atk;
    }

    public void die()
    {
        Debug.Log("HARG JE SUIS MORT");
    }

}
