
int lives_left = 6;
int n_sovp = 0;
bool win = false;
bool lose = false;
string[] words = new string[] { "элемент", "командир", "удар", "лестница", "способ", "состояние", "золото", "президент", "нарушение", "должность", "оплата", "самолет", "сознание", "семья", "сумма" };
Random rnd = new Random();
int word_number = rnd.Next(0, words.Length+1);
string word = words[word_number];
char[] word_hide = new char[word.Length];
for(int i=0; i<word.Length; i++) word_hide[i] = '_';
void Update()
{
    Console.Clear();
    if(lives_left!=7) Console.WriteLine($"осталось {lives_left} жизней");
    switch (lives_left)
    {
        case 6:
            Console.WriteLine(" ______ ");
            Console.WriteLine(" |     | ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            break;
        case 5:
            Console.WriteLine(" ______ ");
            Console.WriteLine(" |     | ");
            Console.WriteLine(" |     0 ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            break;
        case 4:
            Console.WriteLine(" ______ ");
            Console.WriteLine(" |     | ");
            Console.WriteLine(" |     0 ");
            Console.WriteLine(" |     | ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            break;
        case 3:
            Console.WriteLine(" ______ ");
            Console.WriteLine(" |     | ");
            Console.WriteLine(" |     0 ");
            Console.WriteLine(" |    /| ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            break;
        case 2:
            Console.WriteLine(" ______ ");
            Console.WriteLine(" |     | ");
            Console.WriteLine(" |     0 ");
            Console.WriteLine(" |    /|\\ ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            break;
        case 1:
            Console.WriteLine(" ______ ");
            Console.WriteLine(" |     | ");
            Console.WriteLine(" |     0 ");
            Console.WriteLine(" |    /|\\ ");
            Console.WriteLine(" |    /  ");
            Console.WriteLine(" |      ");
            break;
        case 0:
            Console.WriteLine(" ______ ");
            Console.WriteLine(" |     | ");
            Console.WriteLine(" |     0 ");
            Console.WriteLine(" |    /|\\ ");
            Console.WriteLine(" |    / \\");
            Console.WriteLine(" |      ");
            break;
        case 7:
            Console.WriteLine(" ______ ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |      ");
            Console.WriteLine(" |     0 ");
            Console.WriteLine(" |    /|\\ ");
            Console.WriteLine(" |    / \\");
            break;
    }
    for (int i = 0; i < word.Length; i++) Console.Write($"{word_hide[i]} ");
    Console.WriteLine();
    if(win == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вы выиграли!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    if (lose == true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы проиграли!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
Update();
bool game = true;
while(game == true)
{
    Console.WriteLine();
    char pressed_key = Convert.ToChar(Console.ReadLine());
    for (int i = 0; i < word.Length; i++) if (word[i] == pressed_key)
        {
            n_sovp++;
            word_hide[i] = pressed_key;

        }
    if (n_sovp == 0) lives_left--;
    n_sovp = 0;
    Console.WriteLine(pressed_key);
    if(lives_left == 0)
    {
        game = false;
        lose = true;
    }
    for(int i = 0; i < word.Length; i++) if (word_hide[i] == '_') n_sovp++;
    if(n_sovp == 0)
    {
        game = false;
        win = true;
        lives_left = 7;
    }
    n_sovp = 0;
    Update();
}