using System;
using System.Collections.Generic;
using UnityEngine;
public class Ingredient
{
    static List<Ingredient> ingredients = new List<Ingredient>();
    public string name;
	public Color color;
	public double mass;
	public double cost;

	public Ingredient (String name, Color color, double mass, double cost) {
        this.name = name;
        this.color = color;
        this.mass = mass;
        this.cost = cost;
        ingredients.Add(this);
	}

    static public Ingredient GetRandomIngredient() {
        System.Random r = new System.Random();
        int rInt = r.Next(0, ingredients.Count);
        return ingredients[rInt];
    }
}

