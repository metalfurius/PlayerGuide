// Tuples and Enums Culinary Showcase

Console.WriteLine("Welcome to the Culinary Showcase!");

var soup = createDish();
Console.WriteLine($"You have chosen to make a dish with {soup}.");

(foodType, mainIngredient, seasoning) createDish()
{
    foodType food = getFoodType();
    mainIngredient ingredient = ChooseMainIngredient();
    seasoning season = ChooseSeasoning();
    return (food, ingredient, season);
}

foodType getFoodType()
{
    Console.Write("Please choose a type of food (soup, stew, gumbo): ");
    string foodInput = Console.ReadLine();
    return foodInput switch
    {
        "soup" => foodType.soup,
        "stew" => foodType.stew,
        "gumbo" => foodType.gumbo,
        _ => throw new ArgumentException("Invalid food type")
    };
}

mainIngredient ChooseMainIngredient()
{
    Console.Write("Please choose a main ingredient (mushrooms, chicken, carrots, potatoes): ");
    string ingredientInput = Console.ReadLine();
    return ingredientInput switch
    {
        "mushrooms" => mainIngredient.mushrooms,
        "chicken" => mainIngredient.chicken,
        "carrots" => mainIngredient.carrots,
        "potatoes" => mainIngredient.potatoes,
        _ => throw new ArgumentException("Invalid main ingredient")
    };
}

seasoning ChooseSeasoning()
{
    Console.Write("Please choose a seasoning (spicy, salty, sweet): ");
    string seasoningInput = Console.ReadLine();
    return seasoningInput switch
    {
        "spicy" => seasoning.spicy,
        "salty" => seasoning.salty,
        "sweet" => seasoning.sweet,
        _ => throw new ArgumentException("Invalid seasoning")
    };
}



enum foodType { soup, stew, gumbo }
enum mainIngredient { mushrooms, chicken, carrots, potatoes }
enum seasoning { spicy, salty, sweet }