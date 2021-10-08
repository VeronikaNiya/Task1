Console.Write("\nДано натуральное число. Если в нем есть цифры а и b, то определить, какая из них расположена в числе правее. Если одна или обе эти цифры встречаются в числе несколько раз, то должны быть рассмотрены последние из одинаковых цифр");
            int b = rnd.Next(0, 9);
            string strB = b.ToString();
            str.LastIndexOf(strA);//последнее вхождение
            str.LastIndexOf(strB);
            Console.Write("\na = ");
            Console.Write(a);
            Console.Write("\nb = ");
            Console.Write(b);
            if (strA != strB)//если числа не одинаковые
                if (str.Contains(strA) || str.Contains(strB))//если есть хотя бы одно из чисел. Выводит результат, даже если есть только одно из чисел. Это не баг, это фича
                    if (str.LastIndexOf(strA) > str.LastIndexOf(strB)) //чей индекс больше
                        Console.Write("\nЧисло а расположено правее");
                    else
                        Console.Write("\nЧисло b расположено правее");
                else
                    Console.Write("\nТаких цифр нет");
            else Console.Write("\nЦифры повторяются");

            Console.Write("\nЗадание 3");

            Console.Write("\nДля массива, отсортированного по возрастанию, вывести номер элемента, после которого нужно вставить некоторое число y.");
            int[] mas = new int[5];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0, 20);//заполняем рандомными значениями
            }

            //сортировка
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            
            int y = rnd.Next(0, 20);//просто у
            Console.Write("\ny = ");
            Console.Write(y);
            for (int i = 1; i < mas.Length; i++)// ищем место для у
            {
                if ((y > mas[i - 1])  && (y < mas[i]))
                {
                    Console.Write("\ny нужно вставить после индекса ");
                    Console.Write(i - 1);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
