using UnityEngine;
using System.Collections;

public class HelloTaco : MonoBehaviour {
	
	void Start () {
		Ingredient lettuce = new Ingredient ("lettuce", Color.green, 1.0, 0.10);

		Burrito myBurrito = new Burrito ("John");



		myBurrito.AddIngredient ("cheese");
		myBurrito.AddIngredient ("chicken bits");
		myBurrito.AddIngredient ("steak");
		myBurrito.AddIngredient ("lettuce");
		myBurrito.AddIngredient ("ice cream");
		print (myBurrito.IngredientString ());
	}
}
