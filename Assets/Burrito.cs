using System;
using UnityEngine;
using System.Collections.Generic;

public class Burrito
{
	public string name = "";
	public List<Ingredient> ingredients = new List<Ingredient>();

	public Burrito (String burritoName)
	{
		name = burritoName;
	}

	public void AddIngredient(Ingredient ingredient) {
		ingredients.Add (ingredient);
	}

	public string GetIngredientString() {
		string output = name + ":";
		bool addComma = false;
		foreach (Ingredient ingredient in ingredients) {
			if(addComma) {
				output += ", ";
			}
			output += ingredient.name;
			addComma = true;
		}
		return output;
	}

    // TODO: Make this work for new ingredients without having to manually add if statements
    public string debugIngredients() {
        string output = "";
        int numberOfKetchups = 0;
        int numberOfLettuces = 0;
        foreach (Ingredient Dingredient in ingredients) {
            if (Dingredient.name == "ketchup") {
                numberOfKetchups++;
            } else if (Dingredient.name == "lettuce") {
                numberOfLettuces++;
            }
        }
        output = "Ketchup: " + numberOfKetchups + "\n" + "Lettuce: " + numberOfLettuces;
        return output;
    }

    public Double GetCost() {
        Double cost = 0.0;
        foreach (Ingredient ingredient in ingredients) {
            cost += ingredient.cost;
        }
        return cost;
    }
}

