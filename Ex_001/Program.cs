//4. Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды
// (их можно придумать самому). Например:
// SetName – Установить имя
// Help – вывести список команд
// SetPassword – Установить пароль
// Exit – выход
// WriteName – вывести имя после ввода пароля
// Решать отдельной задачей, команды приведены просто для примера, можно добавить свои или вообще использовать другие

bool isWork = true;
string decision,password,name,secondName,email; 
name = password = secondName = email =decision =  "Не указано";
System.Console.WriteLine(decision);
while(isWork)
{
    Console.Write("Напишите, что вы хотите сделать(чтобы получить инструкцию напишите 'Help'): ");
    decision = Console.ReadLine();
    Console.WriteLine(" "); //Пустота
    if(decision.ToLower() == "exit")
    {
        isWork = false;
        Console.WriteLine("Вы вышли из системы!");
        Console.WriteLine(" ");//Пустота
    }
    if(decision.ToLower() == "setname")
    {
        Console.Write("Введите свое имя: ");
        name = Console.ReadLine();
        Console.WriteLine("Отлично, имя установлено!");
        Console.WriteLine(" ");//Пустота
    }    
    if(decision.ToLower() == "setsecondname")
    {
        Console.Write("Введите свою фамилию: ");
        secondName = Console.ReadLine();
        Console.WriteLine("Отлично, фамилия установлена!");
        Console.WriteLine(" ");//Пустота
    }  
    if(decision.ToLower() == "informaboutme")
    {
        Console.WriteLine("Ваше имя: " + name);
        Console.WriteLine("Ваша фамилия: " + secondName);
        Console.WriteLine("Ваш пароль: " + password);
        Console.WriteLine("Ваша электронная почта:  " + email);
        Console.WriteLine(" ");//Пустота
    }
    if(decision.ToLower() == "setpassword")
    {
        Console.Write("Введите свой пароль: ");
        password = Console.ReadLine();
        Console.WriteLine("Отлично, пароль установлен!");
        Console.WriteLine(" ");//Пустота
    }
    if(decision.ToLower() == "setemail")
    {
        Console.Write("Введите свою почту: ");
        email = Console.ReadLine();
        Console.WriteLine("Отлично, почта установлена!");
        Console.WriteLine(" ");//Пустота
    }
    if(decision.ToLower() == "clear") Console.Clear();
    if(decision.ToLower() == "help")
    {
        Console.WriteLine("Все функции программы: ");
        Console.WriteLine(" ");//Пустота
        Console.WriteLine("Setname -  установить свое имя");
        Console.WriteLine("Setsecondname  - установить свою фамилию");
        Console.WriteLine("Setpassword - установить пароль");
        Console.WriteLine("Setemail - указать свою почту");
        Console.WriteLine("InformAboutMe - узнать заполненнужю информацию о себе");
        Console.WriteLine("Clear - очистить терминал");
        Console.WriteLine("Exit - выход  из программы ");
        Console.WriteLine(" ");//Пустота
    }
}


