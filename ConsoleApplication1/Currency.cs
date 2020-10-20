using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Currency
    {
        public int r030 { get; set; }
        public string txt { get; set; }
        public float rate { get; set; }
        public string cc { get; set; }

        public override string ToString()
        {
            return $"Code = {r030}, Name = {txt}, Rate = {rate}, Abrivatur = {cc}";
        }
    }
}
