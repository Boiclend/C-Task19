// Дан текст, который пользователь должен ввести в программу, найти наибольшее количество идущих подряд букв. Реализовать следующие возможности в программе:

//  меню пользователя, состоящее как минимум из 4-х пунктов:
//  ввод данных (текст вводится пользователем );
//  обработка данных (поиск наибольшего количества, подряд идущих, букв);
//  вывод результата на стандартное устройство вывода (экран);
//  выход из программы.
//  организовать промежуточное хранение результата, это относится к пункту меню — вывод результата;
//  разбить программу на функции.


Menu();

int countSymbolInText(string txt) {
    int a = 0;
    int b = 0;
    int count = 0;
    char k = txt[1];
    char symbol = ' ';
        foreach (char c in txt) {
            if (k != c) {
                if (a - b > count) 
                {
                    count = a - b;
                    symbol = k;
                }
                b = a;
                k = c;
            }
        a++;
    }
        if (a - b > count) 
        {
            count = a - b;
            symbol = k;
        }
return count;
}


void Menu() {
Console.WriteLine("Menu:\n1-To enter the string\n2-To process the data\n3-To see result\n0-Exit\n");
int choice = int.Parse(Console.ReadLine());
DateTime time = new DateTime();
string[] text = new string[100];
int count = 0;
int[] res = new int[100];
string[] timeArr = new string[100];
string r;

while (true) {
  
        switch(choice) {
        case 1:
            Console.Write("Введите строку: ");
              if(text[count] != null)
              {
                count++;
              }
            text[count] = Console.ReadLine();
            time = DateTime.Now;
            timeArr[count] = time.ToString();
            break;
        case 2:
            Console.WriteLine("Processing the data..\n");
            for (int i = 0; i <= count; i++)
            {
                r = text[i];
                res[i] = countSymbolInText(r);
            }
            break;
        case 3:
            
           
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine($"\nСтрока - {text[i]}, введена  {timeArr[i]}");
                Console.WriteLine ($"Наибольшее количество идущих подряд букв = {res[i]}");
            }
            break;
        case 0:
            return;
        default:
            Console.WriteLine("\nPlease, enter 0, 1 or 2\n");
            break;
        }
        Console.Write("\nPlease, enter your choice: ");
        choice = int.Parse(Console.ReadLine());
    }
}
    
