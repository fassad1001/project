using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static public class InfoBlockManager
    {
        public int getCurrIB()
        {
            return 1;
        }
        public int getSurenessProcent(int userIntervalBegin, int userIntervalEnd, int programmIntervalBegin, int programmIntervalEnd)
        {
            //на вход подаются интервалы первый a b это пользовательский
            //второй это программный на выход отддеётся цифра - процент уверенности
            return 1;
        }
        public int getNextIBtext_question()
        {
            //информация на вход бурется из текущего состояния программы
            //берется интервал пользователя, набор программных интервалов
            //находим максимальный выхлоп от команды getSurenessProcent и он скажет нам
            //какой блок текста нам надо вызвать, у вызванного блока текста берем 
            //текст и возвращаем его в качестве результата работы функии
            //также обновляем историю инфоблоков у данного пользователя
            return 1;
        }
        public int getNextIBtext_OK()
        {
            //тут мы получаем тот блок текста который мы получис если не будем задавать
            //вопрос по тексту
            return 1;
        }
    }
}
