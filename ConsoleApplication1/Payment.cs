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
        public static bool SerializationAll { get; set; } = true;
        public int PayOnDay { get; set; }
        public int CountDay { get; set; }
        public int PenaltyOnDay { get; set; }
        public int NumberDaysOverdue { get; set; }
        public int Penalty
        {
            get
            {
                if (SerializationAll)
                    return Penalty;
                else
                    return 0;
            }
            set { }
        }

        //public int Penalty { get; }
        public int SummNoPenalty { get;  }
        public int SumTotal { get;  }

        public Payment()
        {

        }

        public Payment(int PayOnDay, int CountDay, int NumberDaysOverdue, int PenaltyOnDay)
        {
            this.PayOnDay = PayOnDay;
            this.CountDay = CountDay;
            this.NumberDaysOverdue = NumberDaysOverdue;
            Penalty = PayOnDay * CountDay;
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
                Penalty = info.GetInt32("Penalty");
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

