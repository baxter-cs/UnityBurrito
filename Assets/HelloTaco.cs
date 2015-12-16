using UnityEngine;
using System.Collections;

public class HelloTaco : MonoBehaviour {
	
	void Start () {
		Ingredient lettuce = new Ingredient ("lettuce", Color.green, 1.0, 0.10);
        Ingredient ketchup = new Ingredient ("ketchup", new Color (204, 0, 153) , 15.0, 0.20);
        Ingredient steak = new Ingredient("steak", new Color(153, 51, 0), 20.0, 1.0);

		Burrito myBurrito = new Burrito ("Random Burrity");
        Burrito weirdBurrito = new Burrito("Crazy Vegan");

        for (int i = 0; i < 5; i++){
            myBurrito.AddIngredient(Ingredient.GetRandomIngredient());
        }

        weirdBurrito.AddIngredient(lettuce);
        weirdBurrito.AddIngredient(ketchup);

		print (myBurrito.GetIngredientString ());
        print(myBurrito.debugIngredients());
        print (weirdBurrito.GetIngredientString ());
        print("Your crazy burrito will cost: " + weirdBurrito.GetCost() + " Doll Hairs");
    }
}
