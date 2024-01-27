namespace Тест_2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            string input = textBox1.Text;
            string code = textBox3.Text;
            string lib = "abcdefghijklmnopqrstuvwxyz";//список символов
            string output = "";//вывод
            bool exit = false;//ошибка ввода
            input = input.ToLower(); input = input.Replace(" ", "");
            code = code.ToLower(); code = code.Replace(" ", "");
            if (input == "" || code == "")
            {
                MessageBox.Show("Недопустимые данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int a = 0, b = 0, el, n = 0;
            bool abool = false, bbool = false;
            
            for (byte m = 0; m < input.Length; m++)// цикл перебора входных символов
            {
                if (n == code.Length)
                {
                    n -= code.Length;
                }
                for (byte i = 0; i <= lib.Length; i++)//цикл подстановки индексов к входному символу
                {
                    if (i == lib.Length)
                    {
                        MessageBox.Show("Недопустимые данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
 
                    if (input[m] == lib[i])
                    {
                        a = i;
                        abool = true;
                    }

                    if (code[n] == lib[i])
                    {
                        b = i;
                        bbool = true;
                    }
                    if (abool == true && bbool == true)
                    {
                        exit = true;
                        break;
                    }

                }

                el = a + b;
                if (el >= lib.Length)
                {
                    el = el - lib.Length;
                }
                output = output + lib[el];
                abool= false;
                bbool= false;
                n++;
            }
            textBox2.Text = output;     public void Test1()
        {
            if (output == "aaf")    }
    }
}