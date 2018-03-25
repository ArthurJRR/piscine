using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    protected string unitName;
    protected int hp;
    protected int atk;
    protected SpriteRenderer sprite;
    protected Animator animator;
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

}
