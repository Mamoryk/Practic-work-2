namespace PW2_3
{
    class programm
    {
        static void Main()
        {
            int i;
            string text;
            Console.WriteLine("1 расшифровать, 0 Зашифровать");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                //deshifr
                Console.WriteLine("Введите текст");
                text=Console.ReadLine();
                cesar Decrypt=new cesar();
                Decrypt.deshiphr(text);

            }
            else
            {
                //shifr
                Console.WriteLine("Введите текст");
                text = Console.ReadLine();
                cesar encrypt = new cesar();
                encrypt.shiphr(text);
            }
        }





    }
    class cesar
    {
          const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
          string  retVal = "";
        int letterQty = alfabet.Length;
           int k = 3;
    public void shiphr(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = alfabet.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + k ) % letterQty;
                    retVal += alfabet[codeIndex];
                }
            }
            Console.WriteLine("Результат");
            Console.WriteLine( retVal );
        }

        public void deshiphr(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = alfabet.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index - k) % letterQty;
                    retVal += alfabet[codeIndex];
                }
            }
            Console.WriteLine("Результат");
            Console.WriteLine(retVal);
        }

    }
}