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
name = secondName = email =decision =  "Не указано";
password = "";
bool passwordStatus = false;
while(isWork)
{
    Console.Write("Напишите, что вы хотите сделать(чтобы получить инструкцию напишите 'Help'): ");
    decision = Console.ReadLine();
    Console.WriteLine(" "); //Пустота
    switch(decision.ToLower())
    {
        case "exit":
            isWork = false;
            Console.WriteLine("Вы вышли из системы!");
            Console.WriteLine(" ");//Пустота
        break;
        case "setname":
            Console.Write("Введите свое имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Отлично, имя установлено!");
            Console.WriteLine(" ");//Пустота
            break;
        case "setsecondname":
            Console.Write("Введите свою фамилию: ");
            secondName = Console.ReadLine();
            Console.WriteLine("Отлично, фамилия установлена!");
            Console.WriteLine(" ");//Пустота
            break;
        case "informaboutme":
            if(string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Чтобы получить данные, нужно установить пароль.");         
                Console.Write("Хотите продолжить?(Напишите 'Yes' or 'No'): ");
                string opinion = Console.ReadLine();  
                if(opinion.ToLower() == "no"){
                    break;
                }
                Console.Write("Установите пароль: ");
                password = Console.ReadLine();
                Console.WriteLine(" ");//Пустота
            
            }
            Console.WriteLine("Ваше имя: " + name);
            Console.WriteLine("Ваша фамилия: " + secondName);
            Console.WriteLine("Ваш пароль: " + password);
            Console.WriteLine("Ваша электронная почта:  " + email);
            Console.WriteLine(" ");//Пустота
            break;
        case "setpassword":
            Console.Write("Введите свой пароль: ");
            password = Console.ReadLine();
            Console.WriteLine("Отлично, пароль установлен!");
            Console.WriteLine(" ");//Пустота
            break;
        case "setemail":
            Console.Write("Введите свою почту: ");
            email = Console.ReadLine();
            Console.WriteLine("Отлично, почта установлена!");
            Console.WriteLine(" ");//Пустота
            break;
        case "clear":
            Console.Clear();
            break;
        case "help":
             Console.WriteLine("Все функции программы: ");
            Console.WriteLine(" ");//Пустота
            Console.WriteLine("Setname -  установить свое имя");
            Console.WriteLine("Setsecondname  - установить свою фамилию");
            Console.WriteLine("Setpassword - установить пароль");
            Console.WriteLine("Setemail - указать свою почту");
            Console.WriteLine("InformAboutMe - узнать заполненную информацию о себе  ");
            Console.WriteLine("Clear - очистить терминал");
            Console.WriteLine("Exit - выход  из программы ");
            Console.WriteLine(" ");//Пустота
            break;
        default:
            Console.WriteLine("Вы не верно ввели команду.");
            break;



    }

}


