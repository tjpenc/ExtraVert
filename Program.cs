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

for (int i = 0; i < plants.Count; i++)
{
  Console.WriteLine($"{plants[i].Species}");
}
