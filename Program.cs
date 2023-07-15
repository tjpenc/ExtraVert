List<Plant> plants = new List<Plant>()
{
  new Plant
  {
    Species = "Borage",
    LightNeeds = 4,
    AskingPrice = 5.00M,
    City = "Johnson City",
    ZIP = "37624",
    Sold = false,
    AvailableUntil = new DateTime(2023, 06, 21)
  },
  new Plant
  {
    Species = "Transcendantia Nanouk",
    LightNeeds = 2,
    AskingPrice = 15.00M,
    City = "Bristol",
    ZIP = "12345",
    Sold = false,
    AvailableUntil = new DateTime(2023, 09, 22)
  },
  new Plant
  {
    Species = "Sunflower",
    LightNeeds = 5,
    AskingPrice = 10.00M,
    City = "Kingsport",
    ZIP = "37660",
    Sold = false,
    AvailableUntil = new DateTime(2023, 08, 23)
  },
  new Plant
  {
    Species = "Indian Ghost Pipe",
    LightNeeds = 1,
    AskingPrice = 25.00M,
    City = "Rogersville",
    ZIP = "37765",
    Sold = false,
    AvailableUntil = new DateTime(2023, 10, 24)
  },
  new Plant
  {
    Species = "Zinnia",
    LightNeeds = 3,
    AskingPrice = 15.00M,
    City = "Johnson City",
    ZIP = "37624",
    Sold = true,
    AvailableUntil = new DateTime(2023, 12, 15)
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
    5. Plant of the Day!
    6. Search Plants by Light Needs");
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
  else if (choice == "6")
  {
    SearchByLightNeeds();
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
    string availableDate = plants[i].AvailableUntil.ToString("dd/MM/yyyy");
    Console.WriteLine($"{i + 1}. {plants[i].Species} in {plants[i].City} {(plants[i].Sold ? "was sold" : "is available")} for {plants[i].AskingPrice} dollars until {availableDate}");
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

  Console.WriteLine("Please enter the date the plant is available until in the format YYYY/MM/DD");
  string dateEntered = Console.ReadLine();
  DateTime availableUntil = new DateTime();
  availableUntil = DateTime.Parse(dateEntered);

  Plant plant = new Plant()
  {
    Species = species,
    LightNeeds = lightNeeds,
    AskingPrice = askingPrice,
    City = city,
    ZIP = zip,
    AvailableUntil = availableUntil
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
    bool isAvailableDatePassed = plant.AvailableUntil < DateTime.Now;
    if (!plant.Sold && !isAvailableDatePassed)
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

void SearchByLightNeeds()
{
  Console.Clear();
  Console.WriteLine("Please enter the maximum light your plants need from 1 (lowest) to 5 (highest)");

  int lightLevelChoice = int.Parse(Console.ReadLine());
  List<Plant> filteredPlants = new List<Plant>();
  foreach (Plant plant in plants)
  {
    if (plant.LightNeeds <= lightLevelChoice) filteredPlants.Add(plant);
  }
  for (int i = 0; i < filteredPlants.Count; i++)
  {
    Console.WriteLine($"{filteredPlants[i].Species} - Light Level Needed: {filteredPlants[i].LightNeeds}");
  }
}
