using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ConsoleApplication1
{
    [Serializable]
    public class Payment : ISerializable
    {
        private static bool SerializationAll { get; set; } = false;
        public int PayOnDay { get; set; }
        public int CountDay { get; set; }
        public int PenaltyOnDay { get; set; }
        public int NumberDaysOverdue { get; set; }
        private int penalty;

        public int Penalty
        {
            get {
                penalty = PayOnDay * CountDay;
                return penalty; }
            //set { }
           
        }

        //public int Penalty;
        public int SummNoPenalty { get; }
        public int SumTotal { get; }

        public Payment()
        {

        }

        public Payment(int PayOnDay, int CountDay, int NumberDaysOverdue, int PenaltyOnDay)
        {
            this.PayOnDay = PayOnDay;
            this.CountDay = CountDay;
            this.NumberDaysOverdue = NumberDaysOverdue;
            this.PenaltyOnDay = PenaltyOnDay;
            penalty = PayOnDay * CountDay;
            SummNoPenalty = PenaltyOnDay * NumberDaysOverdue;
            SumTotal = Penalty + SummNoPenalty;
        }

        Payment(SerializationInfo info, StreamingContext context)
        {
            PayOnDay = info.GetInt32("PayOnDay");
            CountDay = info.GetInt32("CountDay");
            NumberDaysOverdue = info.GetInt32("NumberDaysOverdue");
            PenaltyOnDay = info.GetInt32("PenaltyOnDay");
            if (SerializationAll)
            {
                penalty = info.GetInt32("Penalty");
                SummNoPenalty = info.GetInt32("SumNoPenalty");
                SumTotal = info.GetInt32("SumTotal");
            }
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("PayOnDay", PayOnDay);
            info.AddValue("CountDay", CountDay);
            info.AddValue("NumberDaysOverdue", NumberDaysOverdue);
            info.AddValue("PenaltyOnDay", PenaltyOnDay);

            if (SerializationAll)
            {
                info.AddValue("Penalty", Penalty);
                info.AddValue("SumNoPenalty", SummNoPenalty);
                info.AddValue("SumTotal", SumTotal);
            }
        }

        public override string ToString()
        {
            return $"Оплата за день:                   {PayOnDay }\n" +
                   $"Количесвто дней:                  {CountDay }\n" +
                   $"Штраф за один день:               {PenaltyOnDay }\n" +
                   $"Количесвто дней задержки оплаты:  {NumberDaysOverdue }\n" +
                   $"Сумма к оплате без штрафа:        {SummNoPenalty }\n" +
                   $"Штраф:                            {Penalty}\n" +
                   $"Обшая сумма к оплате:             {SumTotal }\n";
        }
    }
}






