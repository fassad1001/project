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
        public int getSurenessProcent(int IntervalLength, int userIntervalBegin, int userIntervalEnd, int programmIntervalBegin, int programmIntervalEnd)
        {
            //длинна слова оригинала
            //суммарный заступ
            float SummaryIndent;
            //процент попадания
            float ProcOfHit;
            //на вход подаются интервалы первый a b это пользовательский
            //второй это программный на выход отддеётся цифра - процент 
            if (userIntervalBegin >= programmIntervalBegin && userIntervalEnd >= programmIntervalEnd)
            {
                ProcOfHit = (programmIntervalEnd - userIntervalBegin) / IntervalLength;
                SummaryIndent = (userIntervalEnd - programmIntervalEnd) / IntervalLength;
            }
            if (userIntervalBegin <= programmIntervalBegin && userIntervalEnd <= programmIntervalEnd)
            {
                ProcOfHit = (userIntervalEnd - programmIntervalBegin) / IntervalLength;
                SummaryIndent = (programmIntervalBegin - userIntervalBegin) / IntervalLength;
            }
            if (userIntervalBegin >= programmIntervalBegin && userIntervalEnd <= programmIntervalEnd)
            {
                ProcOfHit = (userIntervalEnd - userIntervalBegin) / IntervalLength;
                SummaryIndent  = 0;
            }
            if (userIntervalBegin <= programmIntervalBegin && userIntervalEnd >= programmIntervalEnd)
            {
                ProcOfHit = 1;
                SummaryIndent = ((programmIntervalBegin - userIntervalBegin) + (programmIntervalEnd - userIntervalEnd)) / IntervalLength;
            }

            
            return 1;
        }
        public InfoBlock getLastInfoBlock()
        {
            using (var db = new DataBaseUser())
            {
                return db.History.OrderBy(history => history.Date).Last(a => a.OwnerAccount.Id == AccountManager.CurrUser.Id).OwnerInfoblock;
            }
        }
        public InfoBlock getLastInfoBlock_mainline()
        {
            using (var db = new DataBaseUser())
            {
                return db.History.OrderBy(history => history.Date).Where(a => a.OwnerAccount.Id == AccountManager.CurrUser.Id).Last(a => a.OwnerInfoblock.Course == AccountManager.CurrUser.CurrCourse).OwnerInfoblock;
            }
        }
        public float getNextIBtext_question()
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
