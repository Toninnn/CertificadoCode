/*
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

CalcularSorte();


void CalcularSorte(){
    Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
}



string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    CriarEmails(first: corporate[i,0], last: corporate[i,1]);
    // display internal email addresses
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    CriarEmails(first: external[i,0], last: external[i,1], domain: externalDomain);
    // display external email addresses
}

void CriarEmails(string first, string last, string domain = "contoso.com") 
	{
		string email = first.Substring(0, 2) + last;
		email = email.ToLower();
		Console.WriteLine($"{email}@{domain}");
	}


double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}



double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) 
{   
    int rate = 23500;
    return (int) (rate * usd);

}

double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}



string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}
string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}


string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{

    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if(word[start] != word[end])
        {
            return false;
        }
        start ++;
        end--;
    }
    return true;
}



int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] result = TwoCoins(coins, target);
int[] TwoCoins(int[] coins, int target);


{
    for (int curr = 0; curr < coins.Length; curr++) 
{
    for (int next = curr + 1; next < coins.Length; next++) 
    {
        if (coins[curr] + coins[next] == target) 
        {
            return new int[]{curr, next};
        }

    }
}

    if (result.Length == 0)
    {
        Console.WriteLine("No two coins make change");
    }
    else
    {
        Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
    }
}

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = DefinirAlvo();
        var roll = RolarDados();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll,target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int RolarDados(){
    return random.Next(1,7);
}

int DefinirAlvo(){
    return random.Next(1,6);
}

bool ShouldPlay()
{
    string resposta = Console.ReadLine();
    return resposta.ToLower().Equals("y");
}

string WinOrLose(int roll, int target)
{
    if(roll > target)
    {
        return "You Win";
    }
    else{
        return "You Lose";
    }
}

using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals();
    string[,] group1 = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals() 
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string[,] AssignGroup(int groups) 
{
    int animalsPerGroup = pettingZoo.Length / groups;
    int remainder = pettingZoo.Length % groups;
    string[,] result = new string[groups, animalsPerGroup + (remainder > 0 ? 1 : 0)];
    int start = 0;

    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < animalsPerGroup; j++) 
        {
            if (start < pettingZoo.Length)
                result[i, j] = pettingZoo[start++];
        }

        if (remainder > 0 && start < pettingZoo.Length)
        {
            result[i, animalsPerGroup] = pettingZoo[start++];
            remainder--;
        }
    }

    return result;
}

void PrintGroup(string[,] groups) 
{
    for (int i = 0; i < groups.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++) 
        {
            if (groups[i, j] != null)
                Console.Write($"{groups[i, j]}  ");
        }
        Console.WriteLine();
    }
}


using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

int playerVida= 0;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];


// Index of the current food
int food = 0;

InitializeGame();


void SairJogo()
{
    Console.WriteLine("Program existing");
    shouldExit = true;
    

}

while (!shouldExit)
    {
        Move();
    }

// Returns true if the Terminal was resized 
bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}
void Comeu()
{
    playerVida++;
    player = states[1];

}
// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move()
{
    int lastX = playerX;
    int lastY = playerY;

    player = states[0];

    if(playerX == foodX && playerY == foodY)
    {
        Comeu();
        ShowFood();
        if(food == 2)
        {
            player = states[2];
        }
    }

    

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
            playerY--;
            break;
        case ConsoleKey.DownArrow:
            playerY++;
            break;
        case ConsoleKey.LeftArrow:
            playerX--;
            break;
        case ConsoleKey.RightArrow:
            playerX++;
            break;
        case ConsoleKey.Escape:
            SairJogo();

            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}*/

int productCount = 2000;
string[,] products = new string[productCount, 2];

LoadProducts(products, productCount);

for (int i = 0; i < productCount; i++)
{
    string result;
    result = Process1(products, i);

    if (result != "obsolete")
    {
        result = Process2(products, i);
    }
}

bool pauseCode = true;
while (pauseCode == true) ;

static void LoadProducts(string[,] products, int productCount)
{
    Random rand = new Random();

    for (int i = 0; i < productCount; i++)
    {
        int num1 = rand.Next(1, 10000) + 10000;
        int num2 = rand.Next(1, 101);

        string prodID = num1.ToString();

        if (num2 < 91)
        {
            products[i, 1] = "existing";
        }
        else if (num2 == 91)
        {
            products[i, 1] = "new";
            prodID = prodID + "-n";
        }
        else
        {
            products[i, 1] = "obsolete";
            prodID = prodID + "-0";
        }

        products[i, 0] = prodID;
    }
}

static string Process1(string[,] products, int item)
{
    Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

    return products[item, 1];
}

static string Process2(string[,] products, int item)
{
    Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
    if (products[item, 1] == "new")
        Process3(products, item);

    return "continue";
}

static void Process3(string[,] products, int item)
{
    Console.WriteLine($"Process3 message - processing product information for 'new' product");
}
