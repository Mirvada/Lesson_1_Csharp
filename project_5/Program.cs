//Console.Write("Введите имя пользователя: ");
//string username = Console.ReadLine();

//if(username == "Маша") //Если написать "маша" то программа выдаст "Привет, маша"
    //{
	//Console.WriteLine("Ура, это же Маша");
    //}
//else
    //{
	//Console.Write("Привет, ");
	//Console.WriteLine(username);
    //}

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //В этом случае регистр не важен.
    {
	Console.WriteLine("Ура, это же МАША!");
    }
else
    {
	Console.Write("Привет, ");
	Console.WriteLine(username);
    }