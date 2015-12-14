using System;
using UnityEngine;
using System.Collections.Generic;

public class Burrito
{
	public string name = "";
	public List<String> ingredients = new List<String>();

	public Burrito (String burritoName)
	{
		name = burritoName;
	}

	public void AddIngredient(String ingredient) {
		ingredients.Add (ingredient);
	}

	public string IngredientString() {
		string output = name + ":";
		bool addComma = false;
		foreach (string ingredient in ingredients) {
			if(addComma) {
				output += ", ";
			}
			output += ingredient;
			addComma = true;
		}
		return output;
	}
}

