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

Console.WriteLine("Welcome to ExtraVert");

string choice = null;
while (choice != "0")
{
  Console.WriteLine(@"Please select an option: 
    0. Exit
    1. Display all Plants
    2. Post a Plant
    3. Adopt a Plant
    4. Delist a plant");
    choice = Console.ReadLine();
  if (choice == "0")
  {
    Console.WriteLine("See ya l8er");
  }
  else if (choice == "1")
  {
    throw new NotImplementedException("Display all Plants");
  }
  else if (choice == "2")
  {
    throw new NotImplementedException("Post a plant");
  }
  else if (choice == "3")
  {
    throw new NotImplementedException("Adopt a plant");
  }
  else if (choice == "4")
  {
    throw new NotImplementedException("Delist a plant");
  }
  else
  {
    Console.WriteLine("Choose a viable option");
  }
  Console.WriteLine("Press any key to continue");
  Console.ReadKey();
  Console.Clear();
}
