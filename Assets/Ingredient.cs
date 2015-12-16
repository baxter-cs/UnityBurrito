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

    static private System.Random ImSoRaandom = new System.Random();

    public Ingredient (String name, Color color, double mass, double cost) {
        this.name = name;
        this.color = color;
        this.mass = mass;
        this.cost = cost;
        ingredients.Add(this);
	}

    static public Ingredient GetRandomIngredient() {
        int rInt = ImSoRaandom.Next(0, ingredients.Count);
        return ingredients[rInt];
    }
}

