List<Plant> plants = new List<Plant>()
{
  new Plant
  {
    Species = "Borage",
    LightNeeds = 4,
    AskingPrice = 5.00M,
    City = "Johnson City",
    ZIP = "37624",
    Sold = false
  },
  new Plant
  {
    Species = "Transcendantia Nanouk",
    LightNeeds = 2,
    AskingPrice = 15.00M,
    City = "Bristol",
    ZIP = "12345",
    Sold = false
  },
  new Plant
  {
    Species = "Sunflower",
    LightNeeds = 5,
    AskingPrice = 10.00M,
    City = "Kingsport",
    ZIP = "37660",
    Sold = false
  },
  new Plant
  {
    Species = "Indian Ghost Pipe",
    LightNeeds = 1,
    AskingPrice = 25.00M,
    City = "Rogersville",
    ZIP = "37765",
    Sold = false
  },
  new Plant
  {
    Species = "Zinnia",
    LightNeeds = 3,
    AskingPrice = 15.00M,
    City = "Johnson City",
    ZIP = "37624",
    Sold = true
  }
};
Console.Clear();

Random random = new Random();
int randomIndex;
do 
{
  randomIndex = random.Next(0, plants.Count);
}
while (plants[randomIndex].Sold == true);

string choice = null;
while (choice != "0")
{
  Console.WriteLine("Welcome to ExtraVert");
  Console.WriteLine(@"Please select an option: 
    0. Exit
    1. Display all Plants
    2. Post a Plant
    3. Adopt a Plant
    4. Delist a Plant
    5. Plant of the Day!");
    choice = Console.ReadLine();
  if (choice == "0")
  {
    Console.WriteLine("See ya l8er");
  }
  else if (choice == "1")
  {
    DisplayAllPlants();
  }
  else if (choice == "2")
  {
    PostAPlant();
  }
  else if (choice == "3")
  {
    AdoptAPlant();
  }
  else if (choice == "4")
  {
    DelistAPlant();
  }
  else if (choice == "5")
  {
    ShowPlantOfTheDay();
  }
  else
  {
    Console.WriteLine("Choose a viable option");
  }
  Console.WriteLine("Press any key to continue");
  Console.ReadKey();
  Console.Clear();
}

void DisplayAllPlants()
{
  for (int i = 0; i < plants.Count; i++)
  {
    Console.WriteLine($"{i + 1}. {plants[i].Species} in {plants[i].City} {(plants[i].Sold ? "was sold" : "is available")} for {plants[i].AskingPrice} dollars");
  }
}

void PostAPlant()
{
  Console.Clear();
  Console.WriteLine("Post a plant");

  Console.WriteLine("Please input the plant species");
  string species = Console.ReadLine();

  Console.WriteLine("Please input the plants light needs with an integer from 1 (shade) to 5 (full sun)");
  int lightNeeds = int.Parse(Console.ReadLine());

  Console.WriteLine("Please input your asking price");
  decimal askingPrice = decimal.Parse(Console.ReadLine());

  Console.WriteLine("Please input your city");
  string city = Console.ReadLine();

  Console.WriteLine("Please input your ZIP code");
  string zip = Console.ReadLine();

  Plant plant = new Plant()
  {
    Species = species,
    LightNeeds = lightNeeds,
    AskingPrice = askingPrice,
    City = city,
    ZIP = zip
  };

  plants.Add(plant);
  Console.WriteLine("Plant added!");
}

void AdoptAPlant()
{
  Console.Clear();
  Console.WriteLine("Choose a plant you would like to adopt");
  List<Plant> availablePlants = new List<Plant>();
  foreach (Plant plant in plants)
  {
    if (!plant.Sold)
    {
      availablePlants.Add(plant);
    }
  }
  for (int i = 0; i < availablePlants.Count; i++)
  {
    Console.WriteLine($"{i + 1}. {availablePlants[i].Species}: ${availablePlants[i].AskingPrice}");
  }
  int choice = int.Parse(Console.ReadLine()) - 1;
  availablePlants[choice].Sold = true;
  Console.WriteLine($"Thank you for adopting {availablePlants[choice].Species}");
}

void DelistAPlant()
{
  Console.Clear();
  Console.WriteLine("Choose a plant to delist");
  for (int i = 0; i < plants.Count; i++)
  {
    Console.WriteLine($"{i + 1}. {plants[i].Species}");
  }

  int choice = int.Parse(Console.ReadLine()) - 1;
  Console.WriteLine($"You have removed {plants[choice].Species}");
  plants.RemoveAt(choice);
}

void ShowPlantOfTheDay()
{
  Console.Clear();
  Plant plant = plants[randomIndex];
  Console.WriteLine($"Plant of the Day: {plant.Species}");
  Console.WriteLine(@$"  Location: {plant.City}, {plant.ZIP}
  Light Intensity: {plant.LightNeeds}
  Asking Price: ${plant.AskingPrice}");
}
